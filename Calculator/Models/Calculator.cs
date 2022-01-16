using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator.Models
{
    // Создаем класс калькулятор
    class Calc
    {
        // Создаем закрытое поле значений, которое будет характеризовать математическую операцию и методы доступа к ней
        private string operaciya;
        public string Operaciya
        {
            get => operaciya;
            set
            {
                if (value == "slogenie" || value == "vichitanie" || value == "umnogenie" || value == "delenie" || value == "stepen" || value == null)
                {
                    operaciya = value;
                }
                else
                {
                    operaciya = null;
                }
            }
        }
        // Создаем конструктор калькулятора
        public Calc(string oper)
        {
            Operaciya = oper;
        }
        // Создаем метод для команды сложение
        public (string, string) Slogenie(string a, string b)
        {
            if (Operaciya == null)
            {
                b = a;
                Operaciya = "slogenie";
                a = null;
                return (a, b);
            }
            else
            {
                switch (Operaciya)
                {
                    case "slogenie":
                        a = Convert.ToString(float.Parse(b) + float.Parse(a));
                        break;
                    case "vichitanie":
                        a = Convert.ToString(float.Parse(b) - float.Parse(a));
                        break;
                    case "umnogenie":
                        a = Convert.ToString(float.Parse(b) * float.Parse(a));
                        break;
                    case "delenie":
                        if (float.Parse(a) == 0)
                        {
                            MessageBox.Show("Деление на 0! Зачем же так...(", "Внимание! Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                        {
                            a = Convert.ToString(float.Parse(b) / float.Parse(a));
                        }
                        break;
                    case "stepen":
                        a = Convert.ToString(Math.Pow(float.Parse(b), float.Parse(a)));
                        break;
                }
                Operaciya = "slogenie";
                b = a;
                a = null;
                return (a, b);
            }
        }
        // Создаем метод для команды вычитание
        public (string, string) Vichitanie(string a, string b)
        {
            if (Operaciya == null)
            {
                b = a;
                Operaciya = "vichitanie";
                a = null;
                return (a, b);
            }
            else
            {
                switch (Operaciya)
                {
                    case "slogenie":
                        a = Convert.ToString(float.Parse(b) + float.Parse(a));
                        break;
                    case "vichitanie":
                        a = Convert.ToString(float.Parse(b) - float.Parse(a));
                        break;
                    case "umnogenie":
                        a = Convert.ToString(float.Parse(b) * float.Parse(a));
                        break;
                    case "delenie":
                        if (float.Parse(a) == 0)
                        {
                            MessageBox.Show("Деление на 0! Зачем же так...(", "Внимание! Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                        {
                            a = Convert.ToString(float.Parse(b) / float.Parse(a));
                        }
                        break;
                    case "stepen":
                        a = Convert.ToString(Math.Pow(float.Parse(b), float.Parse(a)));
                        break;
                }
                Operaciya = "vichitanie";
                b = a;
                a = null;
                return (a, b);
            }
        }
        // Создаем метод для команды умножение
        public (string, string) Umnogenie(string a, string b)
        {
            if (Operaciya == null)
            {
                b = a;
                Operaciya = "umnogenie";
                a = null;
                return (a, b);
            }
            else
            {
                switch (Operaciya)
                {
                    case "slogenie":
                        a = Convert.ToString(float.Parse(b) + float.Parse(a));
                        break;
                    case "vichitanie":
                        a = Convert.ToString(float.Parse(b) - float.Parse(a));
                        break;
                    case "umnogenie":
                        a = Convert.ToString(float.Parse(b) * float.Parse(a));
                        break;
                    case "delenie":
                        if (float.Parse(a) == 0)
                        {
                            MessageBox.Show("Деление на 0! Зачем же так...(", "Внимание! Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                        {
                            a = Convert.ToString(float.Parse(b) / float.Parse(a));
                        }
                        break;
                    case "stepen":
                        a = Convert.ToString(Math.Pow(float.Parse(b), float.Parse(a)));
                        break;
                }
                Operaciya = "umnogenie";
                b = a;
                a = null;
                return (a, b);
            }
        }
        // Создаем метод для команды деление
        public (string, string) Delenie(string a, string b)
        {
            if (Operaciya == null)
            {
                b = a;
                Operaciya = "delenie";
                a = null;
                return (a, b);
            }
            else
            {
                switch (Operaciya)
                {
                    case "slogenie":
                        a = Convert.ToString(float.Parse(b) + float.Parse(a));
                        break;
                    case "vichitanie":
                        a = Convert.ToString(float.Parse(b) - float.Parse(a));
                        break;
                    case "umnogenie":
                        a = Convert.ToString(float.Parse(b) * float.Parse(a));
                        break;
                    case "delenie":
                        if (float.Parse(a) == 0)
                        {
                            MessageBox.Show("Деление на 0! Зачем же так...(", "Внимание! Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                        {
                            a = Convert.ToString(float.Parse(b) / float.Parse(a));
                        }
                        break;
                    case "stepen":
                        a = Convert.ToString(Math.Pow(float.Parse(b), float.Parse(a)));
                        break;
                }
                Operaciya = "delenie";
                b = a;
                a = null;
                return (a, b);
            }
        }
        // Создаем метод для команды равно
        public (string, string) Ravno(string a, string b)
        {
            switch (Operaciya)
            {
                case "slogenie":
                    a = Convert.ToString(float.Parse(b) + float.Parse(a));
                    break;
                case "vichitanie":
                    a = Convert.ToString(float.Parse(b) - float.Parse(a));
                    break;
                case "umnogenie":
                    a = Convert.ToString(float.Parse(b) * float.Parse(a));
                    break;
                case "delenie":
                    if (float.Parse(a) == 0)
                    {
                        MessageBox.Show("Деление на 0! Зачем же так...(", "Внимание! Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        a = Convert.ToString(float.Parse(b) / float.Parse(a));
                    }
                    break;
                case "stepen":
                    a = Convert.ToString(Math.Pow(float.Parse(b), float.Parse(a)));
                    break;
            }
            Operaciya = null;
            b = null;
            return (a, b);
        }
        // Создаем метод для команды возведение в степень
        public (string, string) Stepen(string a, string b)
        {
            if (Operaciya == null)
            {
                b = a;
                Operaciya = "stepen";
                a = null;
                return (a, b);
            }
            else
            {
                switch (Operaciya)
                {
                    case "slogenie":
                        a = Convert.ToString(float.Parse(b) + float.Parse(a));
                        break;
                    case "vichitanie":
                        a = Convert.ToString(float.Parse(b) - float.Parse(a));
                        break;
                    case "umnogenie":
                        a = Convert.ToString(float.Parse(b) * float.Parse(a));
                        break;
                    case "delenie":
                        if (float.Parse(a) == 0)
                        {
                            MessageBox.Show("Деление на 0! Зачем же так...(", "Внимание! Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                        {
                            a = Convert.ToString(float.Parse(b) / float.Parse(a));
                        }
                        break;
                    case "stepen":
                        a = Convert.ToString(Math.Pow(float.Parse(b), float.Parse(a)));
                        break;
                }
                Operaciya = "stepen";
                b = a;                
                return (a, b);
            }
        }
        // Создаем метод для команды процент
        public string Procent(string a, string b)
        {
            a = Convert.ToString(float.Parse(b) / 100 * float.Parse(a));
            return a;
        }
    }
}


