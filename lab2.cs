using System;
using System.IO;

namespace lab2
{
    /// <summary>
    /// Реализация практического задания по созданию каталога изданий
    /// </summary>
    class lab2
    {
       /// <summary>
       /// Этот класс используется для дальнейшего наследования
       /// </summary>
        abstract class Source
        {
            public string PubName, surname;
            /// <summary>
            /// Конструктор класса
            /// </summary>
            /// <param name="PubName">Название публикации</param>
            /// <param name="surname">Фамилия автора публикации</param>
            public Source(string PubName, string surname)
            {
                this.PubName = PubName;
                this.surname = surname;
            }
            /// <summary>
            /// Процедура вывода информации на экран</summary>
            public abstract void info();
            /// <summary>
            /// Функция, проверяющая автора произведения
            /// </summary>
            /// <param name="author">Фамилия автора</param>
            /// <returns>Правда или ложь, что написал рассматриваемое произведение</returns>
            public abstract bool match(string author);
        }
        class Book : Source
        {
            string publisher;
            int year;
            /// <summary>
            /// Конструктор класса Book
            /// </summary>
            /// <param name="PubName">Название публикации</param>
            /// <param name="surname">Фамилия автора</param>
            /// <param name="year">Год издания</param>
            /// <param name="publisher">Издатель</param>
            public Book(string PubName, string surname,int year, string publisher) :base(PubName,surname)
            {
                this.publisher = publisher;
                this.year = year;
            }
            /// <summary>
            /// Процедура вывода информации на экран
            /// </summary>
            public override void info()
            {
                Console.WriteLine("Название: " + PubName + "; Фамилия автора: " + surname + "; Год: " + year + "; Издательство: " + publisher);
            }
            /// <summary>
            /// Функция, проверяющая автора произведения
            /// </summary>
            /// <param name="author">Фамилия автора</param>
            /// <returns>Правда или ложь, что написал рассматриваемое произведение</returns>
            public override bool match(string author)
            {
                if (surname == author) return true;
                return false;
            }
        }
        class Paper : Source
        {
            string MagName;
            int number, year;
            /// <summary>
            /// Конструктор класса Paper 
            /// </summary>
            /// <param name="PubName">Название публикации</param>
            /// <param name="surname">Фамилия автора</param>
            /// <param name="MagName">Название журнала</param>
            /// <param name="number">Номер журнала</param>
            /// <param name="year">Год выхода</param>
            public Paper(string PubName, string surname, string MagName, int number, int year) :base(PubName,surname)
            {
                this.MagName = MagName;
                this.number = number;
                this.year = year;
            }
            /// <summary>
            /// Процедура вывода информации на экран
            /// </summary>
            public override void info()
            {
                Console.WriteLine("Название: " + PubName + "; Фамилия автора: " + surname + "; Журнал: " + MagName + "; Номер: " + number + "; Год: " + year);
            }
            /// <summary>
            /// Функция, проверяющая автора произведения
            /// </summary>
            /// <param name="author">Фамилия автора</param>
            /// <returns>Правда или ложь, что написал рассматриваемое произведение</returns>
            public override bool match(string author)
            {
                if (surname == author) return true;
                return false;
            }
        }
        class EResources : Source
        {
            string link, annot;
            /// <summary>
            /// Конструктор класса EResources
            /// </summary>
            /// <param name="PubName">Название публикации</param>
            /// <param name="surname">Фамилия автора</param>
            /// <param name="link">Ссылка</param>
            /// <param name="annot">Аннотация</param>
            public EResources(string PubName, string surname, string link, string annot) :base(PubName,surname)
            {
                this.annot = annot;
                this.link = link;
            }
            /// <summary>
            /// Процедура вывода информации на экран
            /// </summary>
            public override void info()
            {
                Console.WriteLine("Название: " + PubName + "; Фамилия автора: " + surname + "; Ссылка: " + link + "; Аннотация: " + annot);
            }
            /// <summary>
            /// Функция, проверяющая автора произведения
            /// </summary>
            /// <param name="author">Фамилия автора</param>
            /// <returns>Правда или ложь, что написал рассматриваемое произведение</returns>
            public override bool match(string author)
            {
                if (surname == author) return true;
                return false;
            }
        }
        /// <summary>
        /// Главаное тело программы
        /// </summary>
        /// <param name="args">параметр для работы main</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя нужного автора: ");
            string author = Console.ReadLine();
            Source[] catalog = new Source[] {new Book("Nemo1","kek",1900,"izd"),
            new Book("Nemo2","kek",1905,"izd"),
            new EResources("bla","lol","vk.com","tuda-syuda"),
            new Paper("Sport","cheburek","SE",189876,2000)};
            Console.WriteLine("Весь каталог:");
            foreach (Source i in catalog)
                i.info();
            Console.WriteLine("Нужный автор написал следующее: ");
            foreach (Source i in catalog)
                if (i.match(author)) Console.WriteLine(i.PubName);
            Console.ReadLine();
        }
    }
}
