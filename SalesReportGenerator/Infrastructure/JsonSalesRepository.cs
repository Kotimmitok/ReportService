using System.Text.Json;

public class JsonSalesRepository : ISalesRepository
{
    public List<Sale> GetAll()
    {
        return JsonSerializer.Deserialize<List<Sale>>(
            File.ReadAllText("sales.json"))
            ?? new List<Sale>();
    }
}