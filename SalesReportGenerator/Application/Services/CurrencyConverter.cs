public class CurrencyConverter : ICurrencyConverter
{
    public decimal ConvertToUsd(decimal amount, string currency)
    {
        return currency switch
        {
            "USD" => amount,
            "EUR" => amount * 1.1m,
            "GBP" => amount * 1.3m,
            _ => throw new ArgumentException("Unknown currency")
        };
    }
}