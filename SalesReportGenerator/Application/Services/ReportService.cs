public class ReportService : IReportService
{
    private readonly ISalesRepository _repository;
    private readonly ICurrencyConverter _converter;
    private readonly IReportWriter _writer;

    public ReportService(
        ISalesRepository repository,
        ICurrencyConverter converter,
        IReportWriter writer)
    {
        _repository = repository;
        _converter = converter;
        _writer = writer;
    }

    public void CreateReportForYearAndMonth(int year, int month)
    {
        var sales = _repository.GetAll();

        var filtered = sales
            .Where(s => s.Date.Year == year &&
                        s.Date.Month == month);

        var total = filtered.Sum(s =>
            _converter.ConvertToUsd(s.Amount, s.Currency));

        var report = new List<string>
        {
            $"Report {month}/{year}",
            $"Total: {total:F2} USD"
        };

        _writer.Write($"report_{year}_{month}.txt", report);
    }
}
