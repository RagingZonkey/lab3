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
        double Pages_Amount;
        double Price;
        public string Binding_Type;
        static int Object_Counter = 0;
        string value = "     ";
        string amount = "50";
        string Id;
        public int Publ_Year;


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
        public Book(string name, string authors, string pub_house_name, int publ_year, double pages_amount, double price, string binding_type, string id)
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
        public Book(string name, string authors, string pub_house_name, int publ_year, string binding_type, string id, double pages_amount = 502, double price= 10.75)
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

        public void Pages_Per_Ruble (ref Book vl, out double price1)
        {
        price1 = vl.Pages_Amount / vl.Price;
        }

        static Book()
        {
            Console.WriteLine("You are working with a static constructor");

        }

             static void CounterOutput()
        {
            Console.WriteLine("Количество созданных экземпляров объекта Book равно {0}", Object_Counter);
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
            double price1;
            Console.WriteLine("Введите размер массива объектов типа Book: ");
            Size = Convert.ToInt32(Console.ReadLine());
            Book[] Books = new Book[Size];

            //Вызов простого конструктора
            Books[0] = new Book();
            Books[0].Output();


            //Вызов конструктра с параметрами
            Books[1] = new Book("Мертвые души", "Н. Гоголь", "Эксмо", 2018, 320, 7.71, @"""твердый""", "AFCD67");
            Books[1].Output();
            
            //Вызов конструктора с параметрами по умолчанию
            Books[2] = new Book(@"""1984""", "Д. Оруэлл", "АСТ", 2019,  @"""мягкий""", "ASNP85");
            Books[2].Output();
            Books[2].Pages_Per_Ruble(ref Books[2], out price1);
            Console.WriteLine($"В этой книге за 1 рубль в среднем вы получаете {price1} страниц");

            //Trains[0].CounterOutput();

            Console.WriteLine($"Строка представляющая объект Books: {Books[0].ToString()}");

            Console.WriteLine($"Экземпляры Books[0] и Books[1] равны: {Books[0].Equals(Books[1])}");

            Console.WriteLine($"Хеш-код экземпляра Books[0]: {Books[0].GetHashCode()}");

            Console.WriteLine($"Тип экземпляра Books[0]: {Books[0].GetType()}");


            //Поиск книг по автору
            string auth;
            Console.WriteLine("Книги какого автора вы хотите найти?");
            auth = Console.ReadLine();

            for (int i = 0; i < Size; i++)
            {
                if(Books[i].Authors == auth)
                {
                    Console.WriteLine($"Название книги данного автора:  {Books[i].Name} ");
                }
            }

            int year;
            Console.WriteLine("Год, после которого выпущена книга?");
            year = Convert.ToInt32(Console.ReadLine());
           
             for (int i = 0; i < Size; i++)
            {
                if(Books[i].Publ_Year >= year)
                {
                    Console.WriteLine($"Название книги :  {Books[i].Name} ");
                }
            }
        }
    }


}
