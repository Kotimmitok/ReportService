# Sales Report Generator

A small C# application for generating sales reports from sales data.

## Overview

The Sales Report Generator processes sales information and creates summarized reports to provide insights into revenue, products, and sales performance.

## Input Format

The application expects sales data in JSON format:

[
  {
    "Date": "2026-07-01T10:30:00",
    "Amount": 120.50,
    "Currency": "USD"
  },
  {
    "Date": "2026-07-03T15:45:00",
    "Amount": 89.99,
    "Currency": "EUR"
  },
  {
    "Date": "2026-07-10T09:15:00",
    "Amount": 200.00,
    "Currency": "GBP"
  }
]

Each sale contains:
Date:   	Date and time of the transaction
Amount:	    Transaction amount
Currency:	Currency of the transaction

## Features

* Parse sales transaction data
* Convert different currencies into a common reporting currency
* Generate sales summaries
* Calculate total revenue

## Architecture

The project follows a layered architecture:

```
SalesReportGenerator
│
├── Domain
│   └── Core business entities and rules
│
├── Application
│   └── Use cases and service interfaces
│
├── Infrastructure
│   └── Data access and external integrations
│
└── Presentation
    └── Application entry point and user interaction
```

## Example Usage

```csharp
var report = salesReportService.GenerateReport(sales);

Console.WriteLine(report.TotalRevenue);
```

## Technologies

* C#
* .NET

## Future Improvements

Possible extensions:

* Import sales data from databases or external files
* Export reports to PDF or Excel
* Fetch current exchange rates instead of hard coded values
* Add configurable report formats
* Add automated tests
* Add support for scheduled report generation

## Running the Project

Clone the repository and run:

```bash
dotnet run
```