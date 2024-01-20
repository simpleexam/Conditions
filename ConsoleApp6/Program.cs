namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) //бесконечный цикл для удобства
            {
                Console.Clear(); // очистка консоли перед следующим выводом
                Console.WriteLine("введите день недели для вывода расписания");
                string day = Console.ReadLine();

                //оператор switch будет сравнивать содержимое переменной day с возможными случаями для выполнения действий.
                //если совпадений не найдено, выполнится ветка default
                switch (day) 
                {
                    case "понедельник":
                        Console.WriteLine("1. русский язык\n" +
                            "2. программирование\n" +
                            "3. физкультура");
                        break; //оператор break необходим для выхода из оператора switch при обнаружении совпадения.
                    case "вторник":
                        Console.WriteLine("1. математика\n" +
                            "2. информатика\n" +
                            "3. физкультура");
                        break;
                    case "среда":
                        Console.WriteLine("1. физика\n" +
                            "2. география\n" +
                            "3. физкультура");
                        break;
                    case "четверг":
                        Console.WriteLine("1. история\n" +
                            "2. обществознание\n" +
                            "3. физкультура");
                        break;
                    case "пятница":
                        Console.WriteLine("1. программирование\n" +
                            "2. программирование\n" +
                            "3. физкультура");
                        break;
                    case "суббота":
                        Console.WriteLine("1. математика\n" +
                            "2. МДК\n" +
                            "3. физкультура");
                        break;
                    case "воскресение":
                        Console.WriteLine("выходной");
                        break;
                    default:
                        Console.WriteLine("неверно введен день недели");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}