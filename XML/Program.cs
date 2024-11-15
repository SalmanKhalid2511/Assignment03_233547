using System;
using System.Xml;

namespace XMLWriterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (XmlWriter writer = XmlWriter.Create("GPSData.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("GPS");

                writer.WriteStartElement("Position");
                writer.WriteAttributeString("DateTime", DateTime.Now.ToString());
                writer.WriteElementString("x", "65.8973342");
                writer.WriteElementString("y", "72.3452346");

                writer.WriteStartElement("SatelliteInfo");
                writer.WriteElementString("Speed", "40");
                writer.WriteElementString("NoSatt", "7");
                writer.WriteEndElement(); 

                writer.WriteEndElement(); 

                
                writer.WriteStartElement("Image");
                writer.WriteAttributeString("Resolution", "1024x800");
                writer.WriteElementString("Path", @"\images\1.jpg");
                writer.WriteEndElement(); 

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }

            Console.WriteLine("XML file 'GPSData.xml' created successfully.");
        }
    }
}

