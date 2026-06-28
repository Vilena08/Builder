using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // === Сценарий 1: Строим простой PDF-отчёт ===
        IReportBuilder builder = new PdfReportBuilder();
        ReportDirector director = new ReportDirector(builder);

        director.BuildSimpleReport(); // Директор выполняет процесс сборки.
        Report simpleReport = builder.GetReport(); // Забираем готовый продукт.
        simpleReport.Print();

        // === Сценарий 2: Строим полный HTML-отчёт ===
        builder = new HtmlReportBuilder(); // Меняем строителя.
        director = new ReportDirector(builder); // Директор работает с новым строителем.

        director.BuildFullReport(); // Другой сценарий.
        Report fullReport = builder.GetReport();
        fullReport.Print();

        Console.ReadKey();
    }
}