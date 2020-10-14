using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная3_ООП
{



    partial class Book
    {
        public string Name;
        public string Authors;
        public string Publishing_House_Name;
        int Pages_Amount;
        float Price;
        public string Binding_Type;
        static readonly string Id;
        static int Object_Counter = 0;


        public Book()
        {
            Name = "Преступление и наказание";
            Authors = "Ф.М. Достоевский";
            Publishing_House_Name = "Азбука";
            Pages_Amount = 608;
            Price = 8.50;
            Binding_Type = @"""твердый""";
            Id = Name.GetHashCode() + Authors.GetHashCode();
            Object_Counter++;
        }

        static Book()
        {
            Console.WriteLine("You are working with a static constructor");

        }


    }

    partial class Book()
        {

          public void Output()
        {
            Console.WriteLine($"Книга под названием {this.Name}" +
                $" автора {this.Authors}" +
                $" издательства {this.Publishing_House_Name}" +
                $" в переплете типа {this.Binding_Type}" +
                $" толщиной {this.Pages_Amount} страниц, " +
                $"имеет уникальный номер {this.PlacesLuxury} " +
                $"и стоит {this.PlacesReserved} рублей");
        }

        static void Class_Info()
        {
            Console.WriteLine($"Количество созданных экземпляров объекта Book равно: {Objects_Counter}");
        }
      

        }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
