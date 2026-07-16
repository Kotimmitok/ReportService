public class FileReportWriter : IReportWriter
{
    private readonly string _reportsFolder = "reports";

    public void Write(string fileName, IEnumerable<string> lines)
    {
        Directory.CreateDirectory(_reportsFolder);

        var filePath = Path.Combine(_reportsFolder, fileName);

        File.WriteAllLines(filePath, lines);
    }
}