using System;
using System.Diagnostics;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Введiть кiлькiсть чисел: ");
            int countOfNumbs = int.Parse(Console.ReadLine());
            int[] myArray = new int[countOfNumbs];
            bool sortByAsc = false;
            Console.WriteLine("Якщо бажаєте масив по зростанню напишіть 'yes'якщо нi то 'no'");
            string choice = Console.ReadLine();
            if (choice == "yes")
            {
                sortByAsc = true;
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{i + 1 }: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            TSorting tBubble = new TBubble(myArray, sortByAsc);
            Console.WriteLine("Вивiд вiдсортованого масиву методом бульбашки: ");
            int[] bubbleArray = tBubble.Sort();
            for (int i = 0; i < bubbleArray.Length; i++)
            {
                Console.WriteLine(bubbleArray[i]);
            }
            TSorting tChoice = new TChoice(myArray, sortByAsc);
            Console.WriteLine("Вивiд вiдсортованого масиву методом вибору: ");
            int[] choiceArray = tChoice.Sort();
            for (int i = 0; i < choiceArray.Length; i++)
            {
                Console.WriteLine(choiceArray[i]);
            }
            TSorting tQuick = new TQuick(myArray, sortByAsc);
            Console.WriteLine("Вивiд вiдсортованого масиву швидкою сортировкою: ");
            int[] quickArray = tQuick.Sort();
            for (int i = 0; i < quickArray.Length; i++)
            {
                Console.WriteLine(quickArray[i]);
                sum += quickArray[i];
            }
            Console.WriteLine("Вивiд суми елементiв масива");
            Console.WriteLine(sum);

            Stopwatch sw = new Stopwatch();
            Console.WriteLine("Введiть кiлькiсть чисел: ");
            int countOfNumbs1 = int.Parse(Console.ReadLine());
            int[] myArray1 = new int[countOfNumbs1];
            TSorting tBubble1 = new TBubble(myArray1, sortByAsc);
            Random random = new Random();
            for (int i = 0; i < myArray1.Length; i++)
            {
                myArray1[i] = random.Next(0, 50000);
            }
            sw.Start();
            myArray1 = tBubble1.Sort();
            sw.Stop();
            Console.WriteLine("Вивiд вiдсортованого масиву методом бульбашки: ");
            Console.WriteLine("Таймер");
            Console.WriteLine("Мiлiсекунд: " + sw.ElapsedMilliseconds);
            Stopwatch sw1 = new Stopwatch();
            int[] myArray2 = new int[countOfNumbs1];
            TSorting tChoice1 = new TChoice(myArray2, sortByAsc);
            Random random2 = new Random();
            for (int i = 0; i < myArray2.Length; i++)
            {
                myArray2[i] = random2.Next(0, 50000);
            }
            sw1.Start();
            myArray2 = tChoice1.Sort();
            sw1.Stop();
            Console.WriteLine("Вивiд вiдсортованого масиву методом вибору: ");
            Console.WriteLine("Таймер");
            Console.WriteLine("Мiлiсекунд: " + sw1.ElapsedMilliseconds);
            Stopwatch sw2 = new Stopwatch();
            int[] myArray3 = new int[countOfNumbs1];
            TSorting tQuick1 = new TQuick(myArray3, sortByAsc);
            Random random3 = new Random();
            for (int i = 0; i < myArray3.Length; i++)
            {
                myArray3[i] = random3.Next(0, 50000);
            }
            sw2.Start();
            myArray3 = tQuick1.Sort();
            sw2.Stop();
            Console.WriteLine("Вивiд вiдсортованого масиву швидкою сортировкою: ");
            Console.WriteLine("Таймер");
            Console.WriteLine("Мiлiсекунд: " + sw2.ElapsedMilliseconds);
        }
    }
}
