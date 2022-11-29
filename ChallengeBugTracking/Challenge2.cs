namespace ChallengeBugTracking;

public class Challenge2 {
    /// <summary>
    /// Generates a sales report for the last 12 months based on the monthly data given in the database
    /// </summary>
    /// <param name="database">The database of monthly data. The keys are the years, and the values are objects with the keys being the months (1-12) and the values being the sales</param>
    public static int[] GetLast12MonthReport(Dictionary<int, Dictionary<int, int>> data) {
        // TODO: This method does not work, I don't know why.
        // Please have a look, I really don't see anything wrong.
        var today = DateOnly.FromDateTime(DateTime.Now);
        var year = today.Year;
        var d = today.AddYears(-1);
        var report = new List<int>();
        while(d < today) {
            report.Add(data[year][d.Month-1]);
            d = d.AddMonths(1);
        }
        return report.ToArray();
    }
}