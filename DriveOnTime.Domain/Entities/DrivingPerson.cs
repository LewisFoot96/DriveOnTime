using DriveOnTime.Domain.ValueObjects;

namespace DriveOnTime.Domain.Entities;

public abstract class DrivingPerson
{
    public Guid Id { get; set; }
    
    public NameValue FirstName { get; set; }
    
    public NameValue LastName { get; set; }
    
    public string Address { get; set; }

    public DrivingPerson(NameValue firstName, NameValue lastName, string address)
    {
        FirstName = firstName;
        LastName = lastName;
        Address = address;
    }
}