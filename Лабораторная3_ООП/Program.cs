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
        double Price;
        public string Binding_Type;
        static int Object_Counter = 0;
        string value = "     ";
        string amount = "50";
        string Id;
        int Publ_Year;

        //Пустой конструктор
        public Book()
        {
            Name = @"""Преступление и наказание""";
            Authors = "Ф.М. Достоевский";
            Publishing_House_Name = "Азбука";
            Publ_Year = 2015;
            Pages_Amount = 608;
            Price = 8;
            Binding_Type = @"""твердый""";
            Id = "ABCD1";
            Object_Counter++;
        }

        //Конструктор с параметрами
        public Book(string name, string authors, string pub_house_name, int publ_year, int pages_amount, double price, string binding_type, string id)
        {
            Name = name;
            Authors = authors;
            Publishing_House_Name = pub_house_name;
            Publ_Year = publ_year;
            Pages_Amount = pages_amount;
            Price = price;
            Binding_Type = binding_type;
            Id = id;
            Object_Counter++;
        }

        //Конструктор с параметрами по умолчанию 
        public Book(string name, string authors, string pub_house_name, int publ_year, string binding_type, string id, int pages_amount = 502, double price= 10.75)
        {
            Name = name;
            Authors = authors;
            Publishing_House_Name = pub_house_name;
            Publ_Year = publ_year;
            Pages_Amount = pages_amount;
            Price = price;
            Binding_Type = binding_type;
            Id = id;
            Object_Counter++;
        }

        public void Pages_Per_Ruble (ref Book vl, out double price1 )
        {
        price1 = vl.Pages_Amount / vl.Price;
        }

        static Book()
        {
            Console.WriteLine("You are working with a static constructor");

        }

        


         public string Price_GS
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
                $" {this.Publ_Year} года" +
                $" в переплете типа {this.Binding_Type}" +
                $" толщиной {this.Pages_Amount} страниц, " +
                $"имеет уникальный номер {this.Id} " +
                $"и стоит {this.Price} рублей");
            }

    }

   

    class Program
    {
        static void Main(string[] args)
        {
            int Size;
            float price1;
            Console.WriteLine("Введите размер массива объектов типа Book: ");
            Size = Convert.ToInt32(Console.ReadLine());
            Book[] Books = new Book[Size];

            //Вызов простого конструктора
            Books[0] = new Book();
            Books[0].Output();


            //Вызов конструктра с параметрами
            Books[1] = new Book("Мертвые души", "Н. Гоголь", "Эксмо", 320, 7.71, @"""твердый""", 40);
            Trains[1].Output();
            
            //Вызов конструктора с параметрами по умолчанию
            Books[2] = new Book(@"""1984""", "Д. Оруэлл", "АСТ", @"""мягкий""", );
            Books[2].Output();
            Books[2].Pages_Per_Ruble(ref Books[2], out price1);
            Console.WriteLine($"В этой книге 1 рубль в среднем вы получаете {price1} страниц");

            //Trains[0].CounterOutput();

            Console.WriteLine($"Строка представляющая объект Trains: {Trains[0].ToString()}");

            Console.WriteLine($"Экземпляры Trains[0] и Trains[1] равны: {Trains[0].Equals(Trains[1])}");

            Console.WriteLine($"Хеш-код экземпляра Trains[0]: {Trains[0].GetHashCode()}");

            Console.WriteLine($"Тип экземпляра Trains[0]: {Trains[0].GetType()}");

        }
    }


}
