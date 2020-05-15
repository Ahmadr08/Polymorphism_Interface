using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Xml.Serialization;

namespace tugas_polymorphism2
{
    public class Printer
    {
        public string display { get; set; }
        public string status { get; set; }

        internal static void Show()
        {
            Console.WriteLine("");
        }

        internal static void Print()
        {
            Console.WriteLine("");
        }
    }

    public class Printer1
    {
        public string display1 { get; set; }
        public string status1 { get; set; }

    }

    public class Printer2
    {
        public string display2 { get; set; }
        public string status2 { get; set; }

    }

    public class Canon : IPrinterWindows
    {
        public void Convert(Printer ptr)
        {
            Console.WriteLine("");
            string json = JsonConvert.SerializeObject(ptr);
            Console.WriteLine("Hasil dari konversi Json : \n");
            Console.WriteLine(json);
        }

        public void Convert(Printer1 ptr1)
        {
            Console.WriteLine("");
        }

        public void Convert(Printer2 ptr2)
        {
            Console.WriteLine("");
        }
    }

    public class Epson : IPrinterWindows
    {
        public void Convert(Printer1 ptr1)
        {
            using (StringWriter writer = new StringWriter())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Printer1));
                serializer.Serialize(writer, ptr1);

                string xml = writer.ToString();

                Console.WriteLine("Hasil dari konversi XML : \n");
                Console.WriteLine(xml);
            }
        }
        public void Convert(Printer ptr)
        {
            Console.WriteLine("");
        }
        
        public void Convert(Printer2 ptr2)
        {
            Console.WriteLine("");
        }
    }

    public class LaserJet : IPrinterWindows
    {
        public void Convert(Printer2 ptr2)
        {
            Console.WriteLine("");
            string csv = string.Format("{0},{1}", ptr2.display2, ptr2.status2);

            Console.WriteLine("Hasil dari konversi CSV : \n");
            Console.WriteLine(csv);
        }
        internal static void Show()
        {
            Console.WriteLine("LaserJet Display Dimension is 12*12");
        }
        internal static void Print()
        {
            Console.WriteLine(" LaserJet printer is printing...");
        }
        public void Convert(Printer ptr)
        {
            
        }

        public void Convert(Printer1 ptr1)
        {
            
        }
    }
}
