using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Лабораторная3_ООП;

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


        //Пустой конструктор
        public Book()
        {
            Name = "Преступление и наказание";
            Authors = "Ф.М. Достоевский";
            Publishing_House_Name = "Азбука";
            Pages_Amount = 608;
            Additional(ref Price);
            Binding_Type = @"""твердый""";
            Id = Name.GetHashCode() + Authors.GetHashCode();
            Object_Counter++;
        }

        //Конструктор с параметрами
        public Book(string name, string authors, string pub_house_name, int pages_amount, float price, string binding_type, string id)
        {
            Name = name;
            Authors = authors;
            Publishing_House_Name = pub_house_name;
            Pages_Amount = pages_amount;
            Price = price;
            Binding_Type = binding_type;
            Id = id;
            Object_Counter++;
        }

        //Конструктор с параметрами по умолчанию 
        public Book(string name, string authors, string pub_house_name, int pages_amount = 502, float price = 10.75, string binding_type, string id)
        {
            Name = name;
            Authors = authors;
            Publishing_House_Name = pub_house_name;
            Pages_Amount = pages_amount;
            Price = price;
            Binding_Type = binding_type;
            Id = id;
            Object_Counter++;
        }

        public void Pages_Per_Ruble (ref Book vl, out float price1 )
        {
        price1 = vl.Pages_Amount / vl.Price;
        }

        static Book()
        {
            Console.WriteLine("You are working with a static constructor");

        }


    }

    partial class Book()
        {
        string value = "     ";
        string price1 = "03:00";


         public string Price
        {
            get
            {
                return amount;
            }
            protected set
            {
                amount = value;
            }
        }

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
            int Size;
            float price1;
            Console.WriteLine("Введите размер массива классов Books: ");
            Size = Convert.ToInt32(Console.ReadLine());
            Book[] Books = new Book[Size];

            //Вызов простого конструктора
            Book[0] = new Book();
            Trains[0].Output();


            //Вызов конструктра с параметрами
            Trains[1] = new Train("Минск", 706, "6:33", 60, 45, 30, 40);
            Trains[1].Output();
            
            //Вызов конструктора с параметрами по умолчанию
            Trains[2] = new Train("Минск", 60, 45, 30, places4: 30);
            Trains[2].Output();
            Trains[2].AllPlaces(ref Trains[2], out places);
            Console.WriteLine("Количество мест в поезде: {0}", places);

            //Trains[0].CounterOutput();

            Console.WriteLine($"Строка представляющая объект Trains: {Trains[0].ToString()}");

            Console.WriteLine($"Экземпляры Trains[0] и Trains[1] равны: {Trains[0].Equals(Trains[1])}");

            Console.WriteLine($"Хеш-код экземпляра Trains[0]: {Trains[0].GetHashCode()}");

            Console.WriteLine($"Тип экземпляра Trains[0]: {Trains[0].GetType()}");

        }
    }
}
