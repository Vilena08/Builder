public interface IReportBuilder
{
    // Все методы возвращают void, потому что строитель накапливает состояние.
    void SetTitle(string title);
    void SetAuthor(string author);
    void SetPages(int pages);
    void SetFormat(string format);
    Report GetReport(); // В конце возвращаем готовый продукт.
}