using System.Numerics;

namespace ChallengeBugTracking;

public class Challenge1
{
    public static T? Max<T>(IEnumerable<T> items) where T : struct, INumber<T>
    {
        return items.Count() == 0 || items == null ? null : items.Max();
    }
}
