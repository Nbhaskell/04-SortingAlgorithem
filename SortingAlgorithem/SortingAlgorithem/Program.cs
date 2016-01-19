using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = readFromFile();
            Console.WriteLine("Select 1 for bubble sort");
            Console.WriteLine("Select 2 for insertion sort");
            // write in code for bogo sort
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    bubbleSort(list);
                    break;
                case "2":
                    insertionSort(list);
                    break;
                default:
                    Console.WriteLine("Not a valid input. Select 1 for bubble sort or 2 for insertion sort.");
                    break;
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static int[] readFromFile()
        {
            string fileText = File.ReadAllText(@"C:\\dev\\Origin\\04-SortingAlgorithem\\data\\unsortednumbers.txt");
            string[] nString = fileText.Split(',');
            int[] numbers = new int[nString.Length];

            for (int i = 0; i < nString.Length; i++)
            {
                numbers[i] = int.Parse(nString[i]);
            }

            return numbers;
        }

        static void bubbleSort(int[] list)
        {
            printList("Unsorted list", list);

            for (int i = list.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            printList("Sorted list", list);
        }

        static void insertionSort(int[] list)
        {
            printList("Unsorted List", list);

            for (int i = 0; i < list.Length; i++)
            {
                int j = i;

                while (j > 0)
                {
                    if (list[j] < list[j - 1])
                    {
                        int temp = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = temp;
                    }

                    j--;
                }
            }

            printList("Sorted list", list);
        }

        static void printList(string listName, int[] list)
        {
            Console.WriteLine("-- " + listName + " --");
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + ", ");
            }

            Console.WriteLine();
        }
    }
}


/*
private static void bubbleSort(object list)
{
    throw new NotImplementedException();
}
*/


















