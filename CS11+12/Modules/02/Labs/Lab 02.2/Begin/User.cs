namespace Wincubate.CS11.Labs;

class User
{
    // TODO: a1)
    public Guid UserId { get; init; }
	public string FullName { get; set; }
	public string Company { get; set; }
	public bool IsActive { get; set; }

	public User()
	{
	}

	// TODO: a2)
	public User(string fullName)
	{
		UserId = Guid.NewGuid();
		FullName = fullName;
	}

    // TODO: b)
    public override string ToString() => string.Empty;
}