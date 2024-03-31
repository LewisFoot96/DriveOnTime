using DriveOnTime.Domain.ValueObjects;

namespace DriveOnTime.Domain.Entities;

public class DrivingInstructor :  DrivingPerson
{
    private readonly LinkedList<string> _pupils  = new();

    public DrivingInstructor(NameValue firstName, NameValue lastName, string address) : base(firstName, lastName, address)
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

    public void RemovePupil(string pupil)
    {
        var alreadyExists = _pupils.Any(i => i == pupil);

        if (!alreadyExists)
        {
            throw new Exception("Pupil does not exist");
        }
        _pupils.Remove(pupil);
    }
}