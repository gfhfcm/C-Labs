using System;
using System.IO;

namespace lab4
{
    /// <summary>
    /// Класс для реализации поставленной задачи
    /// </summary>
    class Program
    {
        /// <summary>
        /// Общий интерфейс редактора
        /// </summary>
        public interface IAbstractRedactor
        {
            /// <summary>
            /// Функция для возврата настроек нужных определенному типу открываемых файлов
            /// </summary>
            /// <returns>изменяемые настройки</returns>
            IAbstractSettings GetSettings();
        }
        /// <summary>
        /// Класс SQL редактора
        /// </summary>
        class SQLRedactor : IAbstractRedactor
        {
            /// <summary>
            /// Функция для настроек SQL
            /// </summary>
            /// <returns>Настройки редактора под SQL</returns>
            public IAbstractSettings GetSettings()
            {
                return new SQLSettings();
            }
        }
        /// <summary>
        /// Класс С# редактора
        /// </summary>
        class CSHRedactor : IAbstractRedactor
        {
            /// <summary>
            /// Функция для настроек C#
            /// </summary>
            /// <returns>Настройки редактора C#</returns>
            public IAbstractSettings GetSettings()
            {
                return new CSHSettings();
            }
        }
        /// <summary>
        /// Класс HTML редактора
        /// </summary>
        class HTMLRedactor : IAbstractRedactor
        {
            /// <summary>
            /// Настройки HTML редактора
            /// </summary>
            /// <returns>Настройки под HTML</returns>
            public IAbstractSettings GetSettings()
            {
                return new HTMLSettings();
            }
        }
        /// <summary>
        /// Интерфейс настроек
        /// </summary>
        public interface IAbstractSettings
        {
            /// <summary>
            /// Функция выводящая тип файла
            /// </summary>
            /// <returns>Тип файла под изменение настроек</returns>
            string WhichType();
            /// <summary>
            /// Изменение настройки 1
            /// </summary>
            /// <returns>Изменяется настройка 1</returns>
            string SetSettings1();
            /// <summary>
            /// Изменение настройки 2
            /// </summary>
            /// <returns>Изменяется настройка 2</returns>
            string SetSettings2();
            /// <summary>
            /// Изменение настройки 3
            /// </summary>
            /// <returns>Изменяется настройка 3</returns>
            string SetSettings3();
            /// <summary>
            /// Изменение настройки 4
            /// </summary>
            /// <returns>Изменяется настройка 4</returns>
            string SetSettings4();
            /// <summary>
            /// Изменение настройки 5
            /// </summary>
            /// <returns>Изменяется настройка 5</returns>
            string SetSettings5();
            /// <summary>
            /// Изменение настройки 6
            /// </summary>
            /// <returns>Изменяется настройка 6</returns>
            string SetSettings6();
            /// <summary>
            /// Изменение настройки 7
            /// </summary>
            /// <returns>Изменяется настройка 7</returns>
            string SetSettings7();
            /// <summary>
            /// Изменение настройки 8
            /// </summary>
            /// <returns>Изменяется настройка 8</returns>
            string SetSettings8();
            /// <summary>
            /// Изменение настройки 9
            /// </summary>
            /// <returns>Изменяется настройка 9</returns>
            string SetSettings9();
            /// <summary>
            /// Изменение настройки 10
            /// </summary>
            /// <returns>Изменяется настройка 10</returns>
            string SetSettings10();

        }
        /// <summary>
        /// Класс настроек SQL
        /// </summary>
        class SQLSettings : IAbstractSettings
        {
            /// <summary>
            /// Функция выводящая тип файла
            /// </summary>
            /// <returns>тип файла под изменение настроек</returns>
            public string WhichType()
            {
                return "Эти настройки для SQL:";
            }
            /// <summary>
            /// Изменение настройки 1
            /// </summary>
            /// <returns>Изменяется настройка 1</returns>
            public string SetSettings1()
            {
                return "Меняем настройку 1 под SQL";
            }
            /// <summary>
            /// Изменение настройки 2
            /// </summary>
            /// <returns>Изменяется настройка 2</returns>
            public string SetSettings2()
            {
                return "Меняем настройку 2 под SQL";
            }
            /// <summary>
            /// Изменение настройки 3
            /// </summary>
            /// <returns>Изменяется настройка 3</returns>
            public string SetSettings3()
            {
                return "Меняем настройку 3 под SQL";
            }
            /// <summary>
            /// Изменение настройки 4
            /// </summary>
            /// <returns>Изменяется настройка 4</returns>
            public string SetSettings4()
            {
                return "Меняем настройку 4 под SQL";
            }
            /// <summary>
            /// Изменение настройки 5
            /// </summary>
            /// <returns>Изменяется настройка 5</returns>
            public string SetSettings5()
            {
                return "Меняем настройку 5 под SQL";
            }
            /// <summary>
            /// Изменение настройки 6
            /// </summary>
            /// <returns>Изменяется настройка 6</returns>
            public string SetSettings6()
            {
                return "Меняем настройку 6 под SQL";
            }
            /// <summary>
            /// Изменение настройки 7
            /// </summary>
            /// <returns>Изменяется настройка 7</returns>
            public string SetSettings7()
            {
                return "Меняем настройку 7 под SQL";
            }
            /// <summary>
            /// Изменение настройки 8
            /// </summary>
            /// <returns>Изменяется настройка 8</returns>
            public string SetSettings8()
            {
                return "Меняем настройку 8 под SQL";
            }
            /// <summary>
            /// Изменение настройки 9
            /// </summary>
            /// <returns>Изменяется настройка 9</returns>
            public string SetSettings9()
            {
                return "Меняем настройку 9 под SQL";
            }
            /// <summary>
            /// Изменение настройки 10
            /// </summary>
            /// <returns>Изменяется настройка 10</returns>
            public string SetSettings10()
            {
                return "Меняем настройку 10 под SQL";
            }
        }
        /// <summary>
        /// Класс настроек C#
        /// </summary>
        class CSHSettings : IAbstractSettings
        {
            /// <summary>
            /// Функция выводящая тип файла
            /// </summary>
            /// <returns>тип файла под изменение настроек</returns>
            public string WhichType()
            {
                return "Эти настройки для C#:";
            }
            /// <summary>
            /// Изменение настройки 1
            /// </summary>
            /// <returns>Изменяется настройка 1</returns>
            public string SetSettings1()
            {
                return "Меняем настройку 1 под C#";
            }
            /// <summary>
            /// Изменение настройки 2
            /// </summary>
            /// <returns>Изменяется настройка 2</returns>
            public string SetSettings2()
            {
                return "Меняем настройку 2 под C#";
            }
            /// <summary>
            /// Изменение настройки 3
            /// </summary>
            /// <returns>Изменяется настройка 3</returns>
            public string SetSettings3()
            {
                return "Меняем настройку 3 под C#";
            }
            /// <summary>
            /// Изменение настройки 4
            /// </summary>
            /// <returns>Изменяется настройка 4</returns>
            public string SetSettings4()
            {
                return "Меняем настройку 4 под C#";
            }
            /// <summary>
            /// Изменение настройки 5
            /// </summary>
            /// <returns>Изменяется настройка 5</returns>
            public string SetSettings5()
            {
                return "Меняем настройку 5 под C#";
            }
            /// <summary>
            /// Изменение настройки 6
            /// </summary>
            /// <returns>Изменяется настройка 6</returns>
            public string SetSettings6()
            {
                return "Меняем настройку 6 под C#";
            }
            /// <summary>
            /// Изменение настройки 7
            /// </summary>
            /// <returns>Изменяется настройка 7</returns>
            public string SetSettings7()
            {
                return "Меняем настройку 7 под C#";
            }
            /// <summary>
            /// Изменение настройки 8
            /// </summary>
            /// <returns>Изменяется настройка 8</returns>
            public string SetSettings8()
            {
                return "Меняем настройку 8 под C#";
            }
            /// <summary>
            /// Изменение настройки 9
            /// </summary>
            /// <returns>Изменяется настройка 9</returns>
            public string SetSettings9()
            {
                return "Меняем настройку 9 под C#";
            }
            /// <summary>
            /// Изменение настройки 10
            /// </summary>
            /// <returns>Изменяется настройка 10</returns>
            public string SetSettings10()
            {
                return "Меняем настройку 10 под C#";
            }
        }
    
        /// <summary>
        /// Класс настроект HTML
        /// </summary>
        class HTMLSettings:IAbstractSettings
        {
            /// <summary>
            /// Функция выводящая тип файла
            /// </summary>
            /// <returns>тип файла под изменение настроек</returns>
            public string WhichType()
            {
                return "Эти настройки для HTML:";
            }
            /// <summary>
            /// Изменение настройки 1
            /// </summary>
            /// <returns>Изменяется настройка 1</returns>
            public string SetSettings1()
        {
            return "Меняем настройку 1 под HTML";
        }
            /// <summary>
            /// Изменение настройки 2
            /// </summary>
            /// <returns>Изменяется настройка 2</returns>
            public string SetSettings2()
        {
            return "Меняем настройку 2 под HTML";
        }
            /// <summary>
            /// Изменение настройки 3
            /// </summary>
            /// <returns>Изменяется настройка 3</returns>
            public string SetSettings3()
        {
            return "Меняем настройку 3 под HTML";
        }
            /// <summary>
            /// Изменение настройки 4
            /// </summary>
            /// <returns>Изменяется настройка 4</returns>
            public string SetSettings4()
        {
            return "Меняем настройку 4 под HTML";
        }
            /// <summary>
            /// Изменение настройки 5
            /// </summary>
            /// <returns>Изменяется настройка 5</returns>
            public string SetSettings5()
        {
            return "Меняем настройку 5 под HTML";
        }
            /// <summary>
            /// Изменение настройки 6
            /// </summary>
            /// <returns>Изменяется настройка 6</returns>
            public string SetSettings6()
        {
            return "Меняем настройку 6 под HTML";
        }
            /// <summary>
            /// Изменение настройки 7
            /// </summary>
            /// <returns>Изменяется настройка 7</returns>
            public string SetSettings7()
        {
            return "Меняем настройку 7 под HTML";
        }
            /// <summary>
            /// Изменение настройки 8
            /// </summary>
            /// <returns>Изменяется настройка 8</returns>
            public string SetSettings8()
        {
            return "Меняем настройку 8 под HTML";
        }
            /// <summary>
            /// Изменение настройки 9
            /// </summary>
            /// <returns>Изменяется настройка 9</returns>
            public string SetSettings9()
        {
            return "Меняем настройку 9 под HTML";
        }
            /// <summary>
            /// Изменение настройки 10
            /// </summary>
            /// <returns>Изменяется настройка 10</returns>
            public string SetSettings10()
        {
            return "Меняем настройку 10 под HTML";
        }
    }

        /// <summary>
        /// Класс под клиента
        /// </summary>
        class Client
        {
            /// <summary>
            /// Процедура вывода настроек для SQL
            /// </summary>
            public void SQL()
            {
                ClientMethod(new SQLRedactor());
                Console.WriteLine();
            }
            /// <summary>
            /// Процедура вывода настроект C#
            /// </summary>
            public void CSH()
            {
                ClientMethod(new CSHRedactor());
                Console.WriteLine();
            }
            /// <summary>
            /// Процедура вывода настроек HTML
            /// </summary>
            public void HTML()
            {
                ClientMethod(new HTMLRedactor());
                Console.WriteLine();
            }
            /// <summary>
            /// Процедура вывода на экран изменяемых настроек и типа файла
            /// </summary>
            /// <param name="redactor для обращения к функциям интерфейса редактора"></param>
            public void ClientMethod(IAbstractRedactor redactor)
            {
                var Settings = redactor.GetSettings();
                Console.WriteLine(Settings.WhichType());
                Console.WriteLine(Settings.SetSettings1());
                Console.WriteLine(Settings.SetSettings2());
                Console.WriteLine(Settings.SetSettings3());
                Console.WriteLine(Settings.SetSettings4());
                Console.WriteLine(Settings.SetSettings5());
                Console.WriteLine(Settings.SetSettings6());
                Console.WriteLine(Settings.SetSettings7());
                Console.WriteLine(Settings.SetSettings8());
                Console.WriteLine(Settings.SetSettings9());
                Console.WriteLine(Settings.SetSettings10());
            }
        }
        /// <summary>
        /// Функция определения типа вводимого файла
        /// </summary>
        /// <param name="name имя файла"></param>
        /// <returns>тип файла</returns>
        public static string GetType(string name)
        {
            FileInfo test = new FileInfo(name);
            string ext = test.Extension;
            return ext;
        }
        /// <summary>
        /// основное тело программы
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                string name, ext;
                Console.WriteLine("Введите название файла:");
                name = Console.ReadLine();
                ext = GetType(name);
                switch (ext)
                {
                    case ".sql":
                        new Client().SQL();
                        break;
                    case ".cs":
                        new Client().CSH();
                        break;
                    case ".html":
                        new Client().HTML();
                        break;
                    default:
                        Console.WriteLine("Invalid data type! Load the correct file.");
                        break;
                }
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Wrong file name!");
            }
        }
    }
}
