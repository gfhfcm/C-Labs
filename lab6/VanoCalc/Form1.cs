using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VanoCalc
{
    public partial class VanoCalculator : Form
    {
        //создаем эту переменную для последующего понимания момента, в который мы делаем одну из операций калькулятора для очистки после нее поля ввода
        bool operation_pressed = false;
        //переменная для хранения значения вычислений
        double value = 0;
        //переменная для определения текущей операции
        string operation = "";
        public VanoCalculator()
        {
            InitializeComponent();
        }

        private void VanoCalculator_Load(object sender, EventArgs e)
        {

        }
        //Функция для обработки кнопок 0-9 и , и передачи их значений на окно вывода
        private void Button_click(object sender, EventArgs e)
        {
            //если в окне вывода находится ноль, то очищаем его, чтобы он не стоял впереди вывода
            //Например, у нас стоит 0 изначально и тогда при вводе нового числа будет 0 в начале. К примеру, 02
            //Так же очищаем поля ввода, если мы хотим произвести одну из операций
            if ((Result.Text == "0") || (operation_pressed))
                Result.Clear();
            //возвращаем переменной отрицательное значение для последующей корректной работы программы(операция уже считалась, так что истинное значение было бы неверным)
            operation_pressed = false;
            //создаем переменную типа кнопки для последующего считывания информации, переданной на вход процедуре
            Button b = (Button)sender;
            //Оператор ветвления для того, чтобы не допустить многократного ввода запятой
            if(b.Text==",")
            {
                if(!Result.Text.Contains(","))
                    Result.Text = Result.Text + b.Text;
            }
            else
            Result.Text = Result.Text + b.Text;
        }
        //Процедура работы кнопки СЕ для обнуления основного окна вывода и промежуточных вычислений
        private void button33_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
            temp.Text = " ";
        }
        //Процедура обработки операций деления, сложения, вычитания и умножения
        private void Operation_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            //задаем переменной знак операции для последующий вычислений в следующей процедуре
            operation = b.Text;
            //Задаем переменной текущее заданное значение пользователем из окна вывода
            value = Double.Parse(Result.Text);
            //так как нажали на одну из операций, то передаем переменной истинное значение
            operation_pressed = true;
            //В промежуточное окно вывода добавляем исходное число и текущую операцию
            temp.Text = value + " " + operation;
        }
        //процедура обработки клавиши "Равно"
        private void button34_Click(object sender, EventArgs e)
        {
            //очищаем поле промежуточных данных
            temp.Text = " ";
            //через оператор свитч, в зависимости от нажатой операции, производим вычисление
            //Результат вычисления передаем на окно вывода
            //При делении дополнительно обрабатываем деление на 0 и выводим сообщение об ошибке
            switch(operation)
            {
                case "+":
                    Result.Text=(value + Double.Parse(Result.Text)).ToString();
                    break;
                case "-":
                    Result.Text = (value - Double.Parse(Result.Text)).ToString();
                    break;
                case "*":
                    Result.Text = (value * Double.Parse(Result.Text)).ToString();
                    break;
                case "/":
                    if (Result.Text == "0")
                    {
                        Result.Text = "Cannot divide by zero";
                    }
                    else
                    Result.Text = (value / Double.Parse(Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            
        }
        //Процедура считывания чисел и операций с клавиатуры
        private void VanoCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Задаем фокус на кнопке "=" для того, чтобы нажав Enter тоже можно было получить результат вычислений
            equal.Focus();
            //С помощью свитча программа нажимает нужную кнопку на калькуляторе, соответствующую введенной с клавиатуры
            switch (e.KeyChar.ToString())
            {
                case "0":
                    zero.PerformClick();
                    break;
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "*":
                    mult.PerformClick();
                    break;
                case "-":
                    sub.PerformClick();
                    break;
                case "+":
                    add.PerformClick();
                    break;
                case "=":
                    equal.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}
