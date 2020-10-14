using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная3_ООП
{



    partial class Book
    {
        int Id;
        public string Name;
        public string Authors;
        public string Publishing_House_Name;
        int Pages_Amount;
        int Price;
        public string Binding_Type;
        static readonly string R_O = "This is a read-only message";


        public Book()
        {

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
