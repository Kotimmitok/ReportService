public interface IReportWriter
{
    void Write(string fileName, IEnumerable<string> lines);
}