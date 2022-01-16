using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using Microsoft.Win32;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows;
using Calculator.Models;
using System.IO;

namespace Calculator.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        // Создаем экземпляр класса калькулятор
        Calc calc = new Calc(null);        
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        // Создаем закрытые поля значений и методы доступа к ним
        private string znachenie;
        public string Znachenie
        {
            get => znachenie;
            set
            {
                double num;
                bool isNum = double.TryParse(value, out num);
                if (isNum)
                {
                    znachenie = value;
                }
                else
                {
                    znachenie = null;
                }
                OnPropertyChanged();
            }
        }
        private string znachenie2;
        public string Znachenie2
        {
            get => znachenie2;
            set
            {
                double num2;
                bool isNum = double.TryParse(value, out num2);
                if (isNum)
                {
                    znachenie2 = value;
                }
                else
                {
                    znachenie2 = null;
                }
                OnPropertyChanged();
            }
        }
        // Создаем команды для ввода значений
        public ICommand One { get; }
        private void OnOneExecute(object p)
        {
            if (Znachenie == null)
            {
                Znachenie = "1";
            }
            else if (Znachenie.Length==0 && Znachenie != null)
            {
                Znachenie = "1";
            }
            else
            {
                Znachenie = Znachenie + "1";
            }          
        }
        private bool CanZnachenieExecuted(object p)
        {
            return true;
        }
        public ICommand Two { get; }
        private void OnTwoExecute(object p)
        {
            if (Znachenie == null)
            {
                Znachenie = "2";
            }
            else if (Znachenie.Length == 0 && Znachenie != null)
            {
                Znachenie = "2";
            }
            else
            {
                Znachenie = Znachenie + "2";
            }
        }
        public ICommand Three { get; }
        private void OnThreeExecute(object p)
        {
            if (Znachenie == null)
            {
                Znachenie = "3";
            }
            else if  (Znachenie.Length == 0 && Znachenie != null)
            {
                Znachenie = "3";
            }
            else
            {
                Znachenie = Znachenie + "3";
            }
        }
        public ICommand Four { get; }
        private void OnFourExecute(object p)
        {
            if (Znachenie == null)
            {
                Znachenie = "4";
            }
            else if  (Znachenie.Length == 0 && Znachenie != null)
            {
                Znachenie = "4";
            }
            else
            {
                Znachenie = Znachenie + "4";
            }
        }
        public ICommand Five { get; }
        private void OnFiveExecute(object p)
        {
            if (Znachenie == null)
            {
                Znachenie = "5";
            }
            else if  (Znachenie.Length == 0 && Znachenie != null)
            {
                Znachenie = "5";
            }
            else
            {
                Znachenie = Znachenie + "5";
            }
        }
        public ICommand Six { get; }
        private void OnSixExecute(object p)
        {
            if (Znachenie == null)
            {
                Znachenie = "6";
            }
            else if  (Znachenie.Length == 0 && Znachenie != null)
            {
                Znachenie = "6";
            }
            else
            {
                Znachenie = Znachenie + "6";
            }
        }
        public ICommand Seven { get; }
        private void OnSevenExecute(object p)
        {
            if (Znachenie == null)
            {
                Znachenie = "7";
            }
            else if  (Znachenie.Length == 0 && Znachenie != null)
            {
                Znachenie = "7";
            }
            else
            {
                Znachenie = Znachenie + "7";
            }
        }
        public ICommand Eight { get; }
        private void OnEightExecute(object p)
        {
            if (Znachenie == null)
            {
                Znachenie = "8";
            }
            else if  (Znachenie.Length == 0 && Znachenie != null)
            {
                Znachenie = "8";
            }
            else
            {
                Znachenie = Znachenie + "8";
            }
        }
        public ICommand Nine { get; }
        private void OnNineExecute(object p)
        {
            if (Znachenie == null)
            {
                Znachenie = "9";
            }
            else if  (Znachenie.Length == 0 && Znachenie != null)
            {
                Znachenie = "9";
            }
            else
            {
                Znachenie = Znachenie + "9";
            }
        }
        public ICommand Zero { get; }
        private void OnZeroExecute(object p)
        {
            if (Znachenie==null)
            {
                Znachenie = Znachenie + "0,";
            }

            else if (Znachenie != null && Znachenie.IndexOf("0") == 0 && Znachenie.Length == 1)
            {
                Znachenie = Znachenie + ",0";
            }
            else
            {
                Znachenie = Znachenie + "0";
            }
        }
        public ICommand Zapyataya { get; }
        private void OnZapyatayaExecute(object p)
        {
            if (Znachenie!=null&&Znachenie.Length==0)
            {
                Znachenie = Znachenie + "0,";
            }
            else if (Znachenie == null)
            {
                Znachenie = Znachenie + "0,";
            }
            else if (Znachenie.Contains(",") == false)
            {
                Znachenie = Znachenie + ",";
            }
        }
        // Создаем команду для кнопки сброса
        public ICommand Clear { get; }
        private void OnClearExecute(object p)
        {
            Znachenie = null;
            Znachenie2 = null;
            calc.Operaciya = null;
        }
        // Создаем команду для кнопки удалить
        public ICommand Delete { get; }
        private void OnDeleteExecute(object p)
        {
            if (Znachenie == null)
            {
                Znachenie = null;
            }
            else if (Znachenie != null && Znachenie.Length == 0)
            {
                Znachenie = null;
            }            
            else if (Znachenie.Length == 2 && Znachenie.Contains("-") == true)
            {
                Znachenie = null;
            }
            else if (Znachenie != null && Znachenie.Length > 0)
            {
                Znachenie = Znachenie.Remove(Znachenie.Length - 1);
            }
            else
            {
                Znachenie = null;
            }
        }
        // Создаем команду для кнопки возвести в квадрат
        public ICommand Qvadrat { get; }
        private void OnQvadratExecute(object p)
        {
            if (Znachenie != null)
            {
                Znachenie = Convert.ToString((float.Parse(Znachenie) * float.Parse(Znachenie)));
            }
        }
        private bool CanOperaciyaExecuted(object p)
        {
            if (Znachenie == null)
            {
                return false;
            }
            else if (Znachenie != null && Znachenie.Length == 0)
            {
                return false;
            }
            else if (Znachenie != null && Znachenie.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Создаем команду для кнопки 1/X
        public ICommand Delenie1 { get; }
        private void OnDelenie1Execute(object p)
        {

            if (Znachenie == null)
            {
                MessageBox.Show("Деление на 0! Зачем же так...(", "Внимание! Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                Znachenie = null;
            }
            else if (float.Parse(Znachenie) == 0)
            {
                MessageBox.Show("Деление на 0! Зачем же так...(", "Внимание! Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                Znachenie = null;
            }
            else
            {
                Znachenie = Convert.ToString(1 / (float.Parse(Znachenie)));
            }
        }
        // Создаем команду для кнопки pi
        public ICommand Pi { get; }
        private void OnPiExecute(object p)
        {
            Znachenie = Convert.ToString(Math.PI);
        }
        public ICommand Qoren { get; }
        private void OnQorenExecute(object p)
        {
            Znachenie = Convert.ToString(Math.Sqrt(float.Parse(Znachenie)));
        }
        private bool CanQorenExecuted(object p)
        {
            if (Znachenie == null)
            {
                return false;
            }
            else if (Znachenie != null && Znachenie.Length == 0)
            {
                return false;
            }
            else if (Znachenie != null && Znachenie.Length > 0)
            {
                return true;
            }
            else if (Znachenie != null && Znachenie.Contains("-") == true)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
        // Создаем команду для кнопки экспонент
        public ICommand Exponent { get; }
        private void OnExponentExecute(object p)
        {
            Znachenie = Convert.ToString(Math.E);
        }
        // Создаем команду для кнопки экспонент в степени
        public ICommand ExponentStepen { get; }
        private void OnExponentStepenExecute(object p)
        {
            Znachenie = Convert.ToString(Math.Pow(Math.E, (float.Parse(Znachenie))));
        }
        // Создаем команду для кнопки два в степени
        public ICommand DvaVStepen { get; }
        private void OnDvaVStepenExecute(object p)
        {
            Znachenie = Convert.ToString(Math.Pow(2, (float.Parse(Znachenie))));
        }
        // Создаем команду для кнопки +/-
        public ICommand PlusMinus { get; }
        private void OnPlusMinusExecute(object p)
        {
            if (Znachenie.Contains("-") == false)
            {
                Znachenie = Znachenie.Insert(0, "-");
            }
            else if (Znachenie.Contains("-") == true)
            {
                Znachenie = Znachenie.Replace("-","");
            }
        }
        private bool CanPlusMinusExecuted(object p)
        {
            if (Znachenie == null)
            {
                return false;
            }
            else if (Znachenie != null && Znachenie.Length == 0)
            {
                return false;
            }
            else if(Znachenie.Contains("-")==true)
            {
                return true;
            }
                
            else if (float.Parse(Znachenie) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Создаем команду для кнопки +
        public ICommand Plus { get; }
        private void OnPlusExecute(object p)
        {
            (Znachenie, Znachenie2)= calc.Slogenie(Znachenie, Znachenie2);            
        }
        // Создаем команду для кнопки -
        public ICommand Minus { get; }
        private void OnMinusExecute(object p)
        {
            (Znachenie, Znachenie2) = calc.Vichitanie(Znachenie, Znachenie2);
        }
        // Создаем команду для кнопки *
        public ICommand Umnogit { get; }
        private void OnUmnogitExecute(object p)
        {
            (Znachenie, Znachenie2) = calc.Umnogenie(Znachenie, Znachenie2);
        }
        // Создаем команду для кнопки /
        public ICommand Razdelit { get; }
        private void OnRazdelitExecute(object p)
        {
            (Znachenie, Znachenie2) = calc.Delenie(Znachenie, Znachenie2);
        }
        // Создаем команду для кнопки =
        public ICommand Ravno { get; }
        private void OnRavnoExecute(object p)
        {
            (Znachenie, Znachenie2) = calc.Ravno(Znachenie, Znachenie2);
        }
        private bool CanRavnoExecuted(object p)
        {
            if (calc.Operaciya == null)
            {
                return false;
            }
            else if (Znachenie==null)
            {
                return false;
            }
            else if (Znachenie != null && Znachenie.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // Создаем команду для кнопки степень
        public ICommand Stepen { get; }
        private void OnStepenExecute(object p)
        {
            (Znachenie, Znachenie2) = calc.Stepen(Znachenie, Znachenie2);
        }
        // Создаем команду для кнопки %
        public ICommand Procent { get; }
        private void OnProcentExecute(object p)
        {
            Znachenie = calc.Procent(Znachenie, Znachenie2);
        }
        private bool CanProcentExecuted(object p)
        {
            if (calc.Operaciya != null && Znachenie2!=null)
            {
                return true;
            }
            else 
            {
                return false;
            }       
        }
        // Создаем команду для кнопки выход
        public ICommand Exit { get; }
        private void OnExitExecute(object p)
        {
            Application.Current.Shutdown();
        }
        // Создаем команду для кнопки копировать
        public ICommand Copy { get; }
        private void OnCopyExecute(object p)
        {
            Clipboard.SetText(Znachenie);
        }
        private bool CanCopyExecuted(object p)
        {
            if (Znachenie != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Создаем команду для кнопки вставить
        public ICommand Paste { get; }
        private void OnPasteExecute(object p)
        {
            Znachenie = Convert.ToString(Clipboard.GetText());
        }
        // Создаем команду для вызова справки
        public ICommand Spravka { get; }
        private void OnSpravkaExecute(object p)
        {
            Spravka newWindow = new Spravka();
            newWindow.ShowDialog();
        }
        public MainWindowViewModel()
        {
            One = new RelayCommand(OnOneExecute, CanZnachenieExecuted);
            Two = new RelayCommand(OnTwoExecute, CanZnachenieExecuted);
            Three = new RelayCommand(OnThreeExecute, CanZnachenieExecuted);
            Four = new RelayCommand(OnFourExecute, CanZnachenieExecuted);
            Five = new RelayCommand(OnFiveExecute, CanZnachenieExecuted);
            Six = new RelayCommand(OnSixExecute, CanZnachenieExecuted);
            Seven = new RelayCommand(OnSevenExecute, CanZnachenieExecuted);
            Eight = new RelayCommand(OnEightExecute, CanZnachenieExecuted);
            Nine = new RelayCommand(OnNineExecute, CanZnachenieExecuted);
            Zero = new RelayCommand(OnZeroExecute, CanZnachenieExecuted);
            Zapyataya = new RelayCommand(OnZapyatayaExecute, CanZnachenieExecuted);
            Clear = new RelayCommand(OnClearExecute, CanZnachenieExecuted);
            Delete = new RelayCommand(OnDeleteExecute, CanZnachenieExecuted);
            Qvadrat = new RelayCommand(OnQvadratExecute, CanOperaciyaExecuted);
            Delenie1 = new RelayCommand(OnDelenie1Execute, CanOperaciyaExecuted);
            Pi = new RelayCommand(OnPiExecute, CanZnachenieExecuted);
            Qoren = new RelayCommand(OnQorenExecute, CanQorenExecuted);
            Exponent = new RelayCommand(OnExponentExecute, CanZnachenieExecuted);
            ExponentStepen = new RelayCommand(OnExponentStepenExecute, CanOperaciyaExecuted);
            DvaVStepen = new RelayCommand(OnDvaVStepenExecute, CanOperaciyaExecuted);
            PlusMinus = new RelayCommand(OnPlusMinusExecute, CanPlusMinusExecuted);
            Plus = new RelayCommand(OnPlusExecute, CanOperaciyaExecuted);
            Minus = new RelayCommand(OnMinusExecute, CanOperaciyaExecuted);
            Umnogit = new RelayCommand(OnUmnogitExecute, CanOperaciyaExecuted);
            Razdelit = new RelayCommand(OnRazdelitExecute, CanOperaciyaExecuted);
            Ravno = new RelayCommand(OnRavnoExecute, CanRavnoExecuted);
            Stepen = new RelayCommand(OnStepenExecute, CanOperaciyaExecuted);
            Procent = new RelayCommand(OnProcentExecute, CanProcentExecuted);
            Exit= new RelayCommand(OnExitExecute, CanZnachenieExecuted);
            Copy= new RelayCommand(OnCopyExecute, CanCopyExecuted);
            Paste= new RelayCommand(OnPasteExecute, CanZnachenieExecuted);
            Spravka= new RelayCommand(OnSpravkaExecute, CanZnachenieExecuted);
        }
    }
}
