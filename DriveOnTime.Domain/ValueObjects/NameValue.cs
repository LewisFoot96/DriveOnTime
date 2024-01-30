namespace DriveOnTime.Domain.ValueObjects;

public record NameValue
{
    private string Value { get; }

    public NameValue(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new Exception("Name not correct");
        }
        Value = value;
    }

    public static implicit operator string(NameValue name)
        => name.Value;
  
    public static implicit operator NameValue(string name)
        => new(name);
}