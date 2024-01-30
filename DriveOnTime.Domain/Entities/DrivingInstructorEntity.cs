using DriveOnTime.Domain.Entities.Interfaces;
using DriveOnTime.Domain.ValueObjects;

namespace DriveOnTime.Domain.Entities;

public class DrivingInstructorEntity :  DrivingPerson
{
    private readonly LinkedList<string> _pupils  = new();

    public DrivingInstructorEntity(NameValue firstName, NameValue lastName, string address) : base(firstName, lastName, address)
    {
        
    }

    public void AddPupil(string pupil)
    {
        var alreadyExists = _pupils.Any(i => i == pupil);

        if (alreadyExists)
        {
            throw new Exception("Pupil already exists");
        }
        _pupils.AddLast(pupil);
    }
}