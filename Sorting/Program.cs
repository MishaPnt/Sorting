using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть кiлькiсть чисел: ");
            int countOfNumbs = int.Parse(Console.ReadLine());
            int[] myArray = new int[countOfNumbs];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{i+1 }: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            TSorting tBubble = new TBubble(myArray);
            Console.WriteLine("Вивiд вiдсортованого масиву методом бульбашки: ");
            int[] bubbleArray = tBubble.Sort();
            for (int i = 0; i < bubbleArray.Length; i++)
            {
                Console.WriteLine(bubbleArray[i]);
            }
            TSorting tChoice = new TChoice(myArray);
            Console.WriteLine("Вивiд вiдсортованого масиву методом вибору: ");
            int[] choiceArray = tChoice.Sort();
            for (int i = 0; i < choiceArray.Length; i++)
            {
                Console.WriteLine(choiceArray[i]);
            }
            TSorting tQuick = new TQuick(myArray);
            Console.WriteLine("Вивiд вiдсортованого масиву швидкою сортировкою: ");
            int[] quickArray = tQuick.Sort();
            for (int i = 0; i < quickArray.Length; i++)
            {
                Console.WriteLine(quickArray[i]);
            }
        }
    }
}
