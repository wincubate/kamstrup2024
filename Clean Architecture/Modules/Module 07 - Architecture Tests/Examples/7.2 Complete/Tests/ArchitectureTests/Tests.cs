using ArchUnitNET.Domain;
using ArchUnitNET.Fluent;
using ArchUnitNET.Loader;
using ArchUnitNET.xUnit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace ShortR.Tests.ArchitectureTests;

public class Tests
{
    private readonly Architecture _architecture;
    private readonly System.Reflection.Assembly _apiProject;
    private readonly System.Reflection.Assembly _infrastructureProject;
    private readonly System.Reflection.Assembly _applicationProject;
    private readonly System.Reflection.Assembly _domainProject;

    public Tests()
    {
        _apiProject = typeof(Api.Controllers.ShortenController).Assembly;
        _infrastructureProject = typeof(Infrastructure.DependencyInjection).Assembly;
        _applicationProject = typeof(Application.DependencyInjection).Assembly;
        _domainProject = typeof(Domain.ShortenedUrl).Assembly;

        _architecture = new ArchLoader()
            .LoadAssemblies(
                _apiProject,
                _infrastructureProject,
                _applicationProject,
                _domainProject
            )
            .Build();
    }

    [Fact]
    public void DtoMappers_Should_BeInternal()
    {
        IArchRule mapperRule = Classes()
            .That()
            .ResideInAssembly(_apiProject)
            .And()
            .HaveNameEndingWith("Mapper")
            .Should().NotBePublic()
            .Because("they should be internal")
            ;

        mapperRule.Check(_architecture);
    }

    [Fact]
    public void Repositories_Should_BeCorrectlyImplemented()
    {
        var repositoryImplementations = Classes()
            .That()
            .AreNotAbstract().And()
            .HaveNameEndingWith("Repository")
            ;
        var repositoryInterfaces = Interfaces()
            .That()
            .HaveNameEndingWith("Repository")
            ;

        var implementationAssemblyRule = repositoryImplementations
            .Should().ResideInAssembly(_infrastructureProject)
            ;
        var implementationInternalRule = repositoryImplementations
            .Should().BeInternal()
            .Because("they should only be exposed through their interfaces")
            ;
        var interfaceAssemblyrule = repositoryInterfaces
            .Should().ResideInAssembly(_applicationProject)
            .Because("that is required by Clean Architecture")
            ;

        implementationAssemblyRule
            .And(implementationInternalRule)
            .And(interfaceAssemblyrule)
            .Check(_architecture);
    }
}