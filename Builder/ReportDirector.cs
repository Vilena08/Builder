public class ReportDirector
{
    // Директор получает конкретного строителя в конструкторе.
    private IReportBuilder _builder;

    public ReportDirector(IReportBuilder builder)
    {
        _builder = builder;
    }

    // Сценарий сборки №1: простой отчёт.
    public void BuildSimpleReport()
    {
        // Вызовы идут строго в нужном порядке (если он важен).
        _builder.SetTitle("Simple Report");
        _builder.SetAuthor("John Doe");
        _builder.SetPages(5);
        _builder.SetFormat("Text");
    }

    // Сценарий сборки №2: полный отчёт.
    public void BuildFullReport()
    {
        _builder.SetTitle("Full Report");
        _builder.SetAuthor("Jane Smith");
        _builder.SetPages(20);
        _builder.SetFormat("Detailed");
    }
}
