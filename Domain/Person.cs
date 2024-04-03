namespace Domain;

public class BasePerson
{
    private Guid ID = Guid.NewGuid();
}


public class Person : BasePerson
{
    public FullName FullName { get; set; }
    public string Gender { get; set; }
    public DateTime Birthday { get; set; }
    public string PhoneNumber { get; set; }
    public string DiscordNic { get; set; }
}
