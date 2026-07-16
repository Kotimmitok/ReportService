ICurrencyConverter converter = new CurrencyConverter();
IReportService reportService = new ReportService(converter);

reportService.CreateReportForYearAndMonth(2026, 7);