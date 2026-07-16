using System.Text.Json;

public class ReportService : IReportService
{
    private readonly ICurrencyConverter _converter;

    public ReportService(ICurrencyConverter converter)
    {
        _converter = converter;
    }

    public void CreateReportForYearAndMonth(int year, int month)
    {
        var sales = JsonSerializer.Deserialize<List<Sale>>(
            File.ReadAllText("sales.json")) ?? new List<Sale>();

        var filteredSales = sales
            .Where(s => s.Date.Year == year &&
                        s.Date.Month == month);

        decimal total = filteredSales.Sum(s =>
            _converter.ConvertToUsd(s.Amount, s.Currency));

        var report = new List<string>
        {
            $"Monatlicher Verkaufsbericht ({month}/{year})",
            $"Gesamt Umsatz in USD: {total:F2}"
        };

        File.WriteAllLines($"report_{year}_{month}.txt", report);

        Console.WriteLine("Report generated.");
    }
}

