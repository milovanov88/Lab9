using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветстует калькулятор!");
            Console.Write("Введите целое число Х=");
            input(out int x);
            Console.Write("Введите целое число Y=");
            input(out int y);
            Console.WriteLine(@"Введите код операции: 
             1 - сложени
             2 - вычитание
             3 - произвдение
             4 - частное");
            Console.Write("Ваш выбор: ");
            inputOperation(out int operation);
            double action;
            switch (operation)
            {
                case 1:
                    {
                        action = x + y;
                        Console.Write("Результат = ");
                        Console.WriteLine(action);
                        break;
                    }
                case 2:
                    {
                        action = x - y;
                        Console.Write("Результат = ");
                        Console.WriteLine(action);
                        break;
                    }
                case 3:
                    {
                        action = x * y;
                        Console.Write("Результат = ");
                        Console.WriteLine(action);
                        break;
                    }
                case 4:
                    {
                        try
                        {
                            action = Convert.ToDouble(x) / Convert.ToDouble(y);
                            if (y == 0) throw new Exception();
                            Console.Write("Результат = ");
                            Console.WriteLine(action);
                        }
                        catch
                        {
                            
                            Console.WriteLine("Деление на ноль!");
                        }
                        break;
                    }
                default:
                    break;
            }
            Console.ReadKey();
        }
        static void input(out int number)
        {
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода данных! ВВедите значение заново");
                input(out number);
            }
        }
        static void inputOperation(out int number)
        {
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number < 1 || number > 4) throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода данных! ВВедите значение заново");
                inputOperation(out number);
            }
        }
    }
}
