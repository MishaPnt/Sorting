﻿using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum= 0;
            Console.WriteLine("Введiть кiлькiсть чисел: ");
            int countOfNumbs = int.Parse(Console.ReadLine());
            int[] myArray = new int[countOfNumbs];
            bool sortByAsc = true;
            Console.WriteLine("Якщо бажаєте масив по спаданню напишіть 'yes'якщо нi то 'no'");
            string choice = Console.ReadLine();
            if (choice == "yes")
            {
                sortByAsc = false;
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{i+1 }: ");
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
        }
    }
}
