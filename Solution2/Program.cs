using System;
using System.Collections;
using System.Collections.Generic;

public class Document : IComparable<Document>
{
    public string Title { get; set; }
    public int Pages { get; set; }
    public int Importance { get; set; }

    public Document(string title, int pages, int importance)
    {
        Title = title;
        Pages = pages;
        Importance = importance;
    }

    public int CompareTo(Document other)
    {
        return Pages.CompareTo(other.Pages);
    }
}

public class ImportanceComparer : IComparer<Document>
{
    public int Compare(Document x, Document y)
    {
        // Порівнюємо за важливістю, а якщо важливість однакова - за кількістю сторінок
        int importanceComparison = x.Importance.CompareTo(y.Importance);
        return (importanceComparison == 0) ? x.Pages.CompareTo(y.Pages) : importanceComparison;
    }
}

public class DocumentCollection : IEnumerable<Document>
{
    private List<Document> documents = new List<Document>();

    public void AddDocument(Document document)
    {
        documents.Add(document);
    }

    public IEnumerator<Document> GetEnumerator()
    {
        // Сортуємо за кількістю сторінок перед ітерацією
        documents.Sort();
        return documents.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class Program
{
    static void Main()
    {
        // Приклад використання
        Document doc1 = new Document("Document A", 20, 3);
        Document doc2 = new Document("Document B", 15, 2);
        Document doc3 = new Document("Document C", 25, 1);

        DocumentCollection documentCollection = new DocumentCollection();
        documentCollection.AddDocument(doc1);
        documentCollection.AddDocument(doc2);
        documentCollection.AddDocument(doc3);

        foreach (var doc in documentCollection)
        {
            Console.WriteLine($"Title: {doc.Title}, Pages: {doc.Pages}, Importance: {doc.Importance}");
        }
    }
}
