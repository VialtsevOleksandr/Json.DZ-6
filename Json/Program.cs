using System;
using System.Collections.Generic;
using System.IO;
using Json;
using Newtonsoft.Json;

public class Program
{
    public static void Main()
    {
        string json = File.ReadAllText("C:\\Visual Studio project\\Json\\Json\\file.json");

        List<Book> books = JsonConvert.DeserializeObject<List<Book>>(json);

        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Publishing House: {book.PublishingHouse.Name}, Address: {book.PublishingHouse.Adress}");
        }

        string outputJson = JsonConvert.SerializeObject(books, Formatting.Indented);
        File.WriteAllText("C:\\Visual Studio project\\Json\\Json\\outfile.json", outputJson);
    }
}