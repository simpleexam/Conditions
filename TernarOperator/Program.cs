using System.Net.Sockets;

namespace TernarOperator
{
    internal class Program      //проверка числа на четность через тернарный оператор
    {
        static void Main(string[] args)
        {
       

            Console.WriteLine(long.MaxValue);
            while (true) //бесконечный цикл 
            {
                Console.WriteLine("введите число для проверки на четность");
                long number = Int64.Parse(Console.ReadLine()); //считывание c консоли строки и преобразование в тип long (int64)
                                                               //диапазон возможных значений в long:
                                                               //минимальное:      -9223372036854775808
                                                               //максимальное:      9223372036854775807

                string result = ""; //строка с результатом изначально пустая. далее будет перезаписываться

                //с помощью составного условия проверяется вхождение считанного числа в диапазон long
                if (number > long.MaxValue || number < long.MinValue)
                {
                    result = "incorrect data"; //если вне диапазона, в result запишется соответствующая строка
                }
                else //в противном случае, если попадает в диапазон
                {
                    //проверка на четность через тернарный оператор
                    result = number % 2 == 0 ?
                               "число четное" : //запишется в result если (number % 2 == 0) даст истину
                               "число нечетное";//запишется в result если (number % 2 == 0) даст ложь

                                                                    //пример проверки на четность через оператор if..else (для альтернативности)
                                                                    //if (number % 2 == 0)
                                                                    //    result = "число четное";
                                                                    //else
                                                                    //    result = "число не четное";
                }
                Console.WriteLine(result+"\n"); //вывод результата пользователю
            }
        }
    }
}