using FactoryMethod.Model;
using System;

class MainApp
{
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
        // Note: constructors call Factory Method
        List<Document> documents = new List<Document>();
        documents.Add(new Resume());
        documents.Add(new Report());

        // Display document pages
        foreach (Document document in documents)
        {
            Console.WriteLine("\n" + document.GetType().Name + "--");
            foreach (Page page in document.Pages)
            {
                Console.WriteLine(" " + page.GetType().Name);
            }
        }
        // Wait for user
        Console.ReadKey();
    }
}