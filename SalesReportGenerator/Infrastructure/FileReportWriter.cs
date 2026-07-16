public class FileReportWriter : IReportWriter
{
    public void Write(string fileName, IEnumerable<string> lines)
    {
        File.WriteAllLines(fileName, lines);
    }
}