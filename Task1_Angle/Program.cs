using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Angle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Введение исходных данных
                Console.WriteLine("Это - калькулятор перевода угла, представленного в градусах, минутах и секундах в радианы.");
                Console.WriteLine("Значения градусов, минут и секунд берутся по модулю.");
                Console.WriteLine("Введите значение градусов: ");
                double grad = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите значение минут: ");
                double min = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите значение секунд: ");
                double sec = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Вами введен угол {0}°{1:00}\'{2:00}\'\'", grad, min, sec);
                //Обработка

                Angle ang = new Angle(grad, min, sec);
                double radiant = ang.ToRadians();
                
                Console.WriteLine("\nВ радианах угол равен {0}.", Math.Round(radiant,2));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Кажется придётся закрыть программу. Нажмите любую кнопку.");
            }

            Console.ReadKey();
        }
    }
    class Angle
    {
        private double gradus;
        private double minute;
        private double second;

        //Назначаем приватным полям через свойства значения
        public double Gradus
        {
            set
            {
                if (value > 0)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Отрицательное значение градусов не позволяет проводить расчёт, поэтому я возьму модуль введенного числа");
                    gradus = -value;
                }
            }
            get
            {
                return gradus;
            }
        }
        public double Minute
        {
            set
            {
                if (value > 0)
                {
                    minute = value;
                }
                else
                {
                    Console.WriteLine("Отрицательное значение минут не позволяет проводить расчёт, поэтому я возьму модуль введенного числа");
                    minute = -value;
                }
            }
            get
            {
                return minute;
            }
        }
        public double Second
        {
            set
            {
                if (value > 0)
                {
                    second = value;
                }
                else
                {
                    Console.WriteLine("Отрицательное значение секунд не позволяет проводить расчёт, поэтому я возьму модуль введенного числа");
                    second = -value;
                }
            }
            get
            {
                return second;
            }
        }
        // Конструктор
        public Angle(double grad = 0, double min = 0, double sec = 0)
        {
            Gradus = grad;
            Minute = min;
            Second = sec;
        }

        //Метод перевода в радианы
        public double ToRadians()
        {
            double gradOnly = gradus + minute / 60 + second / 3600;
            double radians = gradOnly * Math.PI / 180;
            return radians;
        }



    }
}
