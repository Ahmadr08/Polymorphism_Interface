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
    class Program
    {
        static void Main(string[] args)
        {
            //isi data
            Printer ptr = new Printer();
            ptr.display = "Canon Display Dimension is 9.5*11";
            ptr.status = "Canon printer is printing...";

            Printer1 ptr1 = new Printer1();
            ptr1.display1 = "Epson Display Dimension is 10*11";
            ptr1.status1 = "Epson printer is printing...";

            Printer2 ptr2 = new Printer2();
            ptr2.display2 = "LaserJet Display Dimension is 12*12";
            ptr2.status2 = " LaserJet printer is printing...";

            Console.WriteLine("=======================================");
            Console.WriteLine("| Pilih Printer yang akan digunakan : |");
            Console.WriteLine("| 1. Canon                            |");
            Console.WriteLine("| 2. Epson                            |");
            Console.WriteLine("| 3. LaserJet                         |");
            Console.Write("| Pilih (1-3) : ");
            int pilih = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=======================================");

            IPrinterWindows convert;

            if (pilih == 1)
                convert = new Canon();
            else if (pilih == 2)
                convert = new Epson();
            else
                convert = new LaserJet();

            convert.Convert(ptr);
            convert.Convert(ptr1);
            convert.Convert(ptr2);

            Printer.Show();
            Printer.Print();

            Console.ReadKey();

        }
    }

    
}
