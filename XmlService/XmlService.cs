using System;
using System.Xml;
using System.Xml.Linq;

namespace XmlService1;

public interface IXmlService
{
    XmlDocument LoadXmlFromFile(string fileName);
    void SaveXmlToFile(string fileName);
    string Content { get; }
    void AddPerson(Guid id, string name, int age);
    void DeletePerson(string name);
}


public class XmlService : IXmlService
{
    private XmlDocument xDoc;

    public XmlService()
    {
        xDoc = new XmlDocument();
    }

    public XmlDocument LoadXmlFromFile(string fileName)
    {
        xDoc.Load("persons.xml");
        return xDoc;
    }

    public void SaveXmlToFile(string fileName)
    {
        xDoc.Save(fileName);
    }

    public string Content =>  XDocument.Parse(xDoc.OuterXml).ToString();

    public void AddPerson(Guid id, string name, int age)
    {
        XmlElement xRoot = xDoc.DocumentElement;

        XmlElement personElem = xDoc.CreateElement("person");

        XmlElement idElem = xDoc.CreateElement("id");
        XmlElement nameElem = xDoc.CreateElement("name");
        XmlElement ageElem = xDoc.CreateElement("age");

        XmlText idText = xDoc.CreateTextNode(id.ToString());
        XmlText nameText = xDoc.CreateTextNode(name);
        XmlText ageText = xDoc.CreateTextNode(age.ToString());

        idElem.AppendChild(idText);
        nameElem.AppendChild(nameText);
        ageElem.AppendChild(ageText);

        personElem.AppendChild(idElem);
        personElem.AppendChild(nameElem);
        personElem.AppendChild(ageElem);

        xRoot?.AppendChild(personElem);
    }

    public void DeletePerson(string name)
    {
        var node = xDoc.SelectSingleNode($"//persons[person[name='{name}']]");
        if (node != null)
        {
            node.RemoveChild(node.SelectSingleNode($"//person[name='{name}']"));
        }
    }
}