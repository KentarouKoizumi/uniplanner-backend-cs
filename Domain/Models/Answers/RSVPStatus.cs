using System;

namespace Domain.Models.Answers;

/// <summary>
/// RSVP: 「出欠確認」の意味
/// </summary>
public enum RSVPStatusEnum
{
    OK = 1,
    Maybe = 0,
    No = -1
}

public class RSVPStatus : IEquatable<RSVPStatus>
{
    public RSVPStatusEnum Status { get; }

    public RSVPStatus(RSVPStatusEnum status)
    {
        Status = status;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj))
            return false;
        if (ReferenceEquals(this, obj))
            return true;
        if (obj.GetType() != GetType())
            return false;
        return Equals(obj as RSVPStatus);
    }

    public bool Equals(RSVPStatus? other)
    {
        if (ReferenceEquals(null, other))
            return false;
        if (ReferenceEquals(this, other))
            return true;
        return Status == other.Status;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Status);
    }

    public static bool operator ==(RSVPStatus left, RSVPStatus right)
    {
        return EqualityComparer<RSVPStatus>.Default.Equals(left, right);
    }

    public static bool operator !=(RSVPStatus left, RSVPStatus right)
    {
        return !(left == right);
    }
}

