namespace ChallengeBugTracking.Tests;
using ChallengeBugTracking;

public class Challenge1Tests
{
    [Test]
    public void GetsTheMaximumValueOfAnArrayOfDouble()
    {
        Assert.That(Challenge1.Max(new double[] { 1.0, 3.5, 3.05 }), Is.EqualTo(3.5));
    }

    [Test]
    public void ReturnsNullIfArrayIsEmpty()
    {
        Assert.That(Challenge1.Max(Array.Empty<double>()), Is.EqualTo(null));
    }
}