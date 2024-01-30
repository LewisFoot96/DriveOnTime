using DriveOnTime.Domain.Entities.Interfaces;
using DriveOnTime.Domain.ValueObjects;

namespace DriveOnTime.Domain.Entities;

public class DrivingPupil : DrivingPerson, IAggregateRoot
{
    public DrivingPupil(NameValue firstName, NameValue lastName, string address) : base(firstName, lastName, address)
    {
    }
}