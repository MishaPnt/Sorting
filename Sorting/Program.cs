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
            for (int i = 0; i < myArray[i]; i++)
            {
                tBubble.Sort()[i] = myArray[i];
                Console.WriteLine(tBubble.Sort()[i]);
            }
            TSorting tChoice = new TChoice(myArray);
            Console.WriteLine("Вивiд вiдсортованого масиву методом вибору: ");
            for (int i = 0; i < myArray[i]; i++)
            {
                tChoice.Sort()[i] = myArray[i];
                Console.WriteLine(tChoice.Sort()[i]);
            }
        }
    }
}
