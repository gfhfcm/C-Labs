using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace lab2
{
    /// <summary>
    /// Реализация практического задания по созданию каталога изданий
    /// </summary>
    public class lab2
    {

        /// <summary>
        /// Этот класс используется для дальнейшего наследования
        /// </summary>
        [XmlInclude(typeof(Book))]
        [XmlInclude(typeof(Paper))]
        [XmlInclude(typeof(EResources))]
        [Serializable]
        public abstract class Source
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
            public Source() { }
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
        public sealed class Book : Source
        {
            string publisher,year;
            /// <summary>
            /// Конструктор класса Book
            /// </summary>
            /// <param name="PubName">Название публикации</param>
            /// <param name="surname">Фамилия автора</param>
            /// <param name="year">Год издания</param>
            /// <param name="publisher">Издатель</param>
            public Book(string PubName, string surname,string year, string publisher) :base(PubName,surname)
            {
                Trace.WriteLine("Book.Book");
                this.publisher = publisher;
                this.year = year;
            }
            /// <summary>
            /// Процедура вывода информации на экран
            /// </summary>
            public override void info()
            {
                Trace.WriteLine("Book.info");
                Console.WriteLine("Название: " + PubName + "; Фамилия автора: " + surname + "; Год: " + year + "; Издательство: " + publisher);
            }
            /// <summary>
            /// Функция, проверяющая автора произведения
            /// </summary>
            /// <param name="author">Фамилия автора</param>
            /// <returns>Правда или ложь, что написал рассматриваемое произведение</returns>
            public override bool match(string author)
            {
                Trace.WriteLine("Book.match");
                if (surname == author) return true;
                return false;
            }
            public Book() { }
        }
        public sealed class Paper : Source
        {
            string MagName,number,year;
            /// <summary>
            /// Конструктор класса Paper 
            /// </summary>
            /// <param name="PubName">Название публикации</param>
            /// <param name="surname">Фамилия автора</param>
            /// <param name="MagName">Название журнала</param>
            /// <param name="number">Номер журнала</param>
            /// <param name="year">Год выхода</param>
            public Paper(string PubName, string surname, string MagName, string number, string year) :base(PubName,surname)
            {
                Trace.WriteLine("Paper.Paper");
                this.MagName = MagName;
                this.number = number;
                this.year = year;
            }
            public Paper() { }
            /// <summary>
            /// Процедура вывода информации на экран
            /// </summary>
            public override void info()
            {
                Trace.WriteLine("Paper.info");
                Console.WriteLine("Название: " + PubName + "; Фамилия автора: " + surname + "; Журнал: " + MagName + "; Номер: " + number + "; Год: " + year);
            }
            /// <summary>
            /// Функция, проверяющая автора произведения
            /// </summary>
            /// <param name="author">Фамилия автора</param>
            /// <returns>Правда или ложь, что написал рассматриваемое произведение</returns>
            public override bool match(string author)
            {
                Trace.WriteLine("Paper.match");
                if (surname == author) return true;
                return false;
            }
        }
        public sealed class EResources : Source
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
                Trace.WriteLine("EResources.EResources");
                this.annot = annot;
                this.link = link;
            }
            public EResources() { }
            /// <summary>
            /// Процедура вывода информации на экран
            /// </summary>
            public override void info()
            {
                Trace.WriteLine("EResources.info");
                Console.WriteLine("Название: " + PubName + "; Фамилия автора: " + surname + "; Ссылка: " + link + "; Аннотация: " + annot);
            }
            /// <summary>
            /// Функция, проверяющая автора произведения
            /// </summary>
            /// <param name="author">Фамилия автора</param>
            /// <returns>Правда или ложь, что написал рассматриваемое произведение</returns>
            public override bool match(string author)
            {
                Trace.WriteLine("EResources.match");
                if (surname == author) return true;
                return false;
            }
        }
        /// <summary>
        /// Функция создания каталога публикаций
        /// </summary>
        /// <param name="BookInf">Информация о книгах</param>
        /// <param name="PaperInf">Информация о Журналах</param>
        /// <param name="ERInf">Информация о электронных ресурсах</param>
        /// <returns></returns>
     public static Source[] CreateCatalog(string[] BookInf, string[] PaperInf, string[] ERInf)
        {
            Trace.WriteLine("lab2.CreateCatalog");
            int BookNum, PaperNum, ERNum, temp;
            temp = 0;
            BookNum = Convert.ToInt32(BookInf[0]);
            PaperNum = Convert.ToInt32(PaperInf[0]);
            ERNum = Convert.ToInt32(ERInf[0]);
            int sum = ERNum + BookNum + PaperNum;
            Source[] MainCatalog = new Source[sum];
            for (int i = 1, j = 0; j < BookNum; j++)
            {
                MainCatalog[temp] = new Book(BookInf[i], BookInf[i + 1], BookInf[i + 2], BookInf[i + 3]);
                temp += 1;
                i += 4;
            }
            for (int i = 1, j = 0; j < PaperNum; j++)
            {
                MainCatalog[temp] = new Paper(PaperInf[i], PaperInf[i + 1], PaperInf[i + 2], PaperInf[i + 3], PaperInf[i + 4]);
                i += 5;
                temp += 1;
            }
            for (int i = 1, j = 0; j < ERNum; j++)
            {
                MainCatalog[temp] = new EResources(ERInf[i], ERInf[i + 1], ERInf[i + 2], ERInf[i + 3]);
                i += 4;
                temp += 1;
            }
            return MainCatalog;
        }
        /// <summary>
        /// Главаное тело программы
        /// </summary>
        /// <param name="args">параметр для работы main</param>
        static void Main(string[] args)
        {
            Trace.WriteLine("lab2.Main");
            XmlSerializer serializer = new XmlSerializer(typeof(Source[]));
            
            string[] BookInf = File.ReadAllLines("Book.txt");
            string[] PaperInf = File.ReadAllLines("Paper.txt");
            string[] ERInf = File.ReadAllLines("EResources.txt");
            Source[] MainCatalog = CreateCatalog(BookInf, PaperInf, ERInf);
            foreach (Source i in MainCatalog)
            {
                i.info();
            }
            
            Console.WriteLine("Введите имя нужного автора: ");
            string author = Console.ReadLine();
            Console.WriteLine("Нужный автор написал следующее: ");
            foreach (Source i in MainCatalog)
            {
                if (i.match(author)) Console.WriteLine(i.PubName);
            }
            using (StringWriter textWriter = new StringWriter())
            {
                serializer.Serialize(textWriter, MainCatalog);
                Console.WriteLine(textWriter.ToString());
            }
            using (StreamWriter streamWriter = new StreamWriter("db.xml"))
            {
                serializer.Serialize(streamWriter, MainCatalog);
            }
            Console.ReadLine();
        }
    }
}
