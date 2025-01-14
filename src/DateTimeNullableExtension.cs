using System.Diagnostics.Contracts;

namespace Soenneker.Extensions.DateTime.Nullable;

/// <summary>
/// A collection of helpful DateTime? extension methods
/// </summary>
public static class DateTimeNullableExtension
{
    /// <summary>
    /// Determines whether the nullable date part of the current <see cref="System.DateTime"/> object is equal to the nullable date part of another <see cref="System.DateTime"/> object.
    /// </summary>
    /// <param name="dateTime">The nullable <see cref="System.DateTime"/> object to compare to the target.</param>
    /// <param name="target">The nullable <see cref="System.DateTime"/> object to compare with the current object.</param>
    /// <returns>true if both dates are null or if the date parts of <paramref name="dateTime"/> and <paramref name="target"/> are equal; otherwise, false.</returns>
    [Pure]
    public static bool IsEqualTo(this System.DateTime? dateTime, System.DateTime? target)
    {
        if (dateTime is null && target == null)
            return true;

        // If only one of them is null, they are not equal
        if (dateTime is null || target == null)
            return false;

        if (dateTime.Value.Date != target.Value.Date)
            return false;

        return true;
    }
}
