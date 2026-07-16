public interface ICurrencyConverter
{
    decimal ConvertToUsd(decimal amount, string currency);
}