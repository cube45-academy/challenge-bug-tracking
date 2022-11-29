namespace ChallengeBugTracking.Tests;
using ChallengeBugTracking;

public class Challenge2Tests
{
    private Dictionary<int, Dictionary<int, int>> data = new Dictionary<int, Dictionary<int, int>>();

    [OneTimeSetUp]
    public void Setup()
    {
        // Generates the data. Assume this is correct.
        var today = DateTime.Now;
        for (var y = today.Year - 2; y <= today.Year; y++)
        {
            var d = new Dictionary<int, int>();
            for (var m = 1; m <= ((y == today.Year) ? today.Month-1 : 12); m++)
            {
                d.Add(m, Random.Shared.Next(1000));
            }
            data.Add(y, d);
        }
    }

    [Test]
    public void MustHaveExactly12Month()
    {
        Assert.That(Challenge2.GetLast12MonthReport(data).Length, Is.EqualTo(12));
    }

    [Test]
    public void MustReturnAListOfMonthStartingAndEndingWithTheCorrectMonth()
    {
        var today = DateTime.Now;
        var report = Challenge2.GetLast12MonthReport(data);
        Assert.That(report[0], Is.EqualTo(data[today.Year-1][today.Month]));
        Assert.That(report[11], Is.EqualTo(data[today.Year][today.Month-1]));
    }
}