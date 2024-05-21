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
        // TODO
    }
}