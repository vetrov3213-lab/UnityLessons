using System.Text;

namespace Homework_21_05_26
{
    public class RomanConverter
    {
        // Задание 1
        //метод для определения хвоста для числа
        //Если цифра больше или равна 5, метод должен вычесть из нее 5 и вернуть остаток.
        //Если меньше 5 — вернуть саму цифру.
        private int GetTailCount(int digit)
        {
            // ТВОЙ КОД ЗДЕСЬ: напиши решение в одну строчку через тернарный оператор ?:
            //return ...
            //как начнешь делать, строку ниже убери
            throw new NotImplementedException();
        }

        // Кирпичик 2
        /* Допиши цикл `while`, который с помощью `% 10` (взятие последней цифры) и `/ 10` 
         * (отсечение последней цифры) заполняет массив с конца.
         * 
         */
        private int[] SplitNumber(int num)
        {
            int[] digits = new int[4];
            int temp = num;
            int i = 3; // Индекс последней ячейки массива (единицы)

            while (temp > 0 && i >= 0)
            {
                // ТВОЙ КОД ЗДЕСЬ:
                // 1. Положи в digits[i] последнюю цифру числа temp
                // 2. Уменьши temp в 10 раз
                // 3. Уменьши индекс i на 1
            }

            return digits;
        }

        // Кирпичик 3
        private void TranslateDigit(int digit, string one, string five, StringBuilder sb)
        {
            if (digit == 4)
            {
                // ТВОЙ КОД ЗДЕСЬ: добавь в sb.Append(...) символ one, а затем символ five
            }
            else
            {
                // 1. Вызываем наш первый кирпичик
                int count = GetTailCount(digit);

                // 2. ТВОЙ КОД ЗДЕСЬ: если digit >= 5, добавь в sb символ five

                // 3. ТВОЙ КОД ЗДЕСЬ: напиши цикл for, который выполнится count раз 
                //    Раз за разом добавляй в sb символ one
            }
        }

        // ГЛАВНЫЙ МЕТОД (Соединяет всё вместе)
        public string IntToRoman(int num)
        {
            if (num < 1 || num > 3999) return "Неверное число";

            var ones = new string[] { "M", "C", "X", "I" };
            var fives = new string[] { "", "D", "L", "V" };

            //спцеиальный писатель, который создает одну общую строку с помощью метода Append(подстрока)
            StringBuilder sb = new StringBuilder();

            //определяем переменную-массив digits через вызов метода SplitNumber(num)
            //цикл for (int i = 0 ...), который проходится по всем цифрам, начиная с тысяч (с индекса 0)
            //берем цифру:
            //  1. если цифра == 0, то пропускаем итерацию с помощью continue
            //  2. если цифра 9, то дописываем в sb ones[i] и ones [i-1]
            //  3. иначе вызываем метод TranslateDigit, передавая туда: саму цифру, ones[i], fives[i] и sb

            return sb.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            RomanConverter converter = new RomanConverter();

            Console.WriteLine(converter.IntToRoman(3954)); // Выведет: MMMCMLIV
            Console.WriteLine(converter.IntToRoman(3075)); // Выведет: MMMLXXV
        }
    }
}
