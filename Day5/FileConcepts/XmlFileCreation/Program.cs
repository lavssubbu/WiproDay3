// See https://aka.ms/new-console-template for more information
using System.Xml;
using Xmlwriterconc;

Console.WriteLine("Hello, World!");

Course[] crs = new Course[3];
crs[0] = new Course() { Cid = 11, Name = "DotnetCore" };
crs[1] = new Course() { Cid = 12, Name = "Angular" };
crs[2] = new Course() { Cid = 13, Name = "React" };

using (XmlWriter xmlw = XmlWriter.Create("course.xml"))
{
    xmlw.WriteStartDocument();
    xmlw.WriteStartElement("Courses");  

    foreach (Course c in crs)
    {
        xmlw.WriteStartElement("Course");
        xmlw.WriteAttributeString("CID", c.Cid.ToString());
        xmlw.WriteElementString("CName", c.Name);
       // Console.WriteLine(c.Cid+" "+c.Name);
       xmlw.WriteEndElement();
    }
    xmlw.WriteEndElement();
    xmlw.WriteEndDocument();
    Console.WriteLine();
}