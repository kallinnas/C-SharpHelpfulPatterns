using System.Xml.Linq;

namespace C_HelpfulPatterns;

//Завдання: Виведіть назви всіх книг, які мають більше 300 сторінок.
internal class ParseXml
{
    public void Run()
    {
        XDocument doc = XDocument.Parse(xmlData);

        var books = from book in doc.Descendants("Book")
                    where (int)book.Element("Pages") > 300
                    select book.Element("Title").Value;

        foreach (var title in books)
        {
            Console.WriteLine(title);
        }
    }

    string xmlData = @"
        <Books>
            <Book>
                <Title>Book 1</Title>
                <Pages>200</Pages>
            </Book>
            <Book>
                <Title>Book 2</Title>
                <Pages>350</Pages>
            </Book>
            <Book>
                <Title>Book 3</Title>
                <Pages>150</Pages>
            </Book>
            <Book>
                <Title>Book 4</Title>
                <Pages>400</Pages>
            </Book>
        </Books>";
}
