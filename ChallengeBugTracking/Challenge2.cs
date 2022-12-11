namespace ChallengeBugTracking;

public class Challenge2 {
    /// <summary>
    /// Generates a sales report for the last 12 months based on the monthly data given in the database
    /// </summary>
    /// <param name="database">The database of monthly data. The keys are the years, and the values are objects with the keys being the months (1-12) and the values being the sales</param>
    public static int[] GetLast12MonthReport(Dictionary<int, Dictionary<int, int>> data) {
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        DateOnly pastYearDate = today.AddYears(-1);
        List<int> report = new List<int>();
        while(pastYearDate < today) {
            report.Add(data[pastYearDate.Year][pastYearDate.Month]);
            pastYearDate = pastYearDate.AddMonths(1);
        }
        return report.ToArray();
    }
}