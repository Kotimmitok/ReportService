using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

public class ReportService
{
    public void CreateReportForYearAndMonth(int year, int month)
    {
        var allSales = JsonSerializer.Deserialize<List<SaleObject>>(
            File.ReadAllText("sales.json"));

        var filtered = allSales
            .Where(s => s.Date.Year == year && s.Date.Month == month)
            .ToList();

        double total = 0;

        foreach (var sale in filtered)
        {
            if (sale.Currency == "USD")
            {
                total = total + sale.Amount;
            }
            else if (sale.Currency == "EUR")
            {
                total = total + sale.Amount * 1.1;
            }
            else if (sale.Currency == "GBP")
            {
                total = total + sale.Amount * 1.3;
            }
        }

        var reportRows = new List<string>
        {
            $"Monatlicher Verkaufsbericht ({month}/{year})",
            $"Gesamt Umsatz in USD: {total}"
        };

        File.WriteAllLines($"report_{year}_{month}.txt", reportRows);
        Console.WriteLine("Report generated successfully.");
    }
}


