ISalesRepository repository = new JsonSalesRepository();
ICurrencyConverter converter = new CurrencyConverter();
IReportWriter writer = new FileReportWriter();

IReportService reportService =
    new ReportService(repository, converter, writer);

reportService.CreateReportForYearAndMonth(2026, 7);