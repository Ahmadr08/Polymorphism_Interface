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
    public interface IPrinterWindows
    {
        void Convert(Printer ptr);
        void Convert(Printer1 ptr1);
        void Convert(Printer2 ptr2);

    }
}
