using System.Diagnostics.CodeAnalysis;

namespace Wincubate.CS11.Labs;

class User
{
    // TODO: a1)
    public required Guid UserId { get; init; }
	public required string FullName { get; set; }
	public string? Company { get; set; }
	public required bool? IsActive { get; set; }

	public User()
	{
	}

	// TODO: a2)
	[SetsRequiredMembers]
	public User(string fullName)
	{
		UserId = Guid.NewGuid();
		FullName = fullName;
	}

    // TODO: b)
    public override string ToString() => $$"""
      {{UserId}} : "{{FullName}}"
      {{Company ?? "---"}}
      {{IsActive switch
	  {	true => "Active",
	  	false => "Deactivated",
	  	_ => "No activation status"
	  }}}
    """;
}