using System;

public class Report
{
    // Это финальный продукт, который мы собираем.
    // У него есть свойства, но он не знает, как его строили.
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public string Format { get; set; }

    // Метод для демонстрации результата.
    public void Print()
    {
        Console.WriteLine($"{Title}: {Author}, {Pages} pages, {Format}");
    }
}