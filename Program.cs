using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Dechode_lesson3_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            Console.WriteLine("Task1: ");
            int[] nums_task1 = { 6, 3, 2, 9, 5, 2, 6, 7, 8, 2, 3 };
        point:
            Console.Write("Enter index of the first number you want to sum: ");

            int index1 = int.Parse(Console.ReadLine());
            Console.Write("Enter index of the second number you want to sum: ");
            int index2 = int.Parse(Console.ReadLine());
            if (index1 >= nums_task1.Length || index2 >= nums_task1.Length || index1 < 1 || index2 < 1)
            {
                Console.WriteLine($"Please enter index from 1 to {nums_task1.Length}");
                goto point;
            }
            else
            {
                Console.WriteLine($"Sum of {index1}th and {index2}th numbers is {nums_task1[index1 - 1] + nums_task1[index2 - 1]}");
            }




            //task2
            int[] nums_task2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < nums_task2.Length / 2; i++) // Length/2 yaziriq ki evvelki hala qayitmasin
            {
                nums_task2[i] = nums_task2[nums_task2.Length - 1 - i] + nums_task2[i];
                nums_task2[nums_task2.Length - 1 - i] = nums_task2[i] - nums_task2[nums_task2.Length - 1 - i];
                nums_task2[i] = nums_task2[i] - nums_task2[nums_task2.Length - 1 - i];
            }
            Console.WriteLine("\n\nTask2. Inverse position of array:");
            for (int i = 0; i < nums_task2.Length; i++)
            {
                Console.WriteLine(nums_task2[i]);
            }


            //task3
            Console.WriteLine("\n\n\nTask3: ");
            int[] nums_task3 = { 5, 9, 2, 0, 1, 7 };
            int[] nums_task3_2 = { 19, 2, 8, 0, 9, 3, 0, 1, 6, 7 };
            bool isExisting = false;
            for (int i = 0; i < nums_task3.Length; i++)
            {
                for (int j = 0; j < nums_task3_2.Length; j++)
                {
                    if (nums_task3[i] == nums_task3_2[j])
                    {
                        isExisting = true;
                        break;
                    }
                    else
                    {
                        isExisting = false;
                    }
                }
                if (isExisting == false)
                {
                    break;
                }
            }
            Console.WriteLine($"Birinci array daxilinde olan butun ededler ikinci array daxilində de var: {isExisting} ");


            //task4
            Console.WriteLine("\n\n\nTask4: ");
            bool DuplicateExist = false;
            int[] nums_task4 = { 3, 6, 7, 1, 8, 6, 39, 34, 34 };
            for (int i = 1; i < nums_task4.Length; i++)
            {
                if (nums_task4[i] == nums_task4[i - 1])
                {
                    DuplicateExist = true;
                    break;
                }
            }
            Console.WriteLine($"Array daxilinde eyni reqemden yan-yana duplicate var: {DuplicateExist}");


            //task5
            Console.WriteLine("\n\n\nTask5. Array daxilinde: ");
            int[] nums_task5 = { 4, 5, 2, 43, 8, 7, 5, 43, 2, 199, 2 };
            int count = 1;
            for (int i = 0; i < nums_task5.Length; i++)
            {
                if (nums_task5[i] == 0)
                {
                    continue;
                }
                for (int j = i+1; j < nums_task5.Length; j++)
                {
                    
                    if (nums_task5[i] == nums_task5[j])
                    {
                        count++;
                        nums_task5[j] = 0;
                    }
                }
                Console.WriteLine($"{count} dene {nums_task5[i]} var");
                if (count > 1){
                    count = 1;
                }
            }





            //task6
            Console.WriteLine("\n\n\nTask6. Sorted array:  ");
            int[] nums_task6 = { 9, 6, 4, 3, 2, 5, 1, 10, 7, 8 };
            for (int i = 0; i < nums_task6.Length; i++)
            {
                for (int j = i + 1; j < nums_task6.Length; j++)
                {
                    if (nums_task6[i] > nums_task6[j])
                    {
                        nums_task6[i] = nums_task6[j] + nums_task6[i]; //yerlerin deyisdirmek ucun
                        nums_task6[j] = nums_task6[i] - nums_task6[j];
                        nums_task6[i] = nums_task6[i] - nums_task6[j];
                    }
                }
            }
            for (int i = 0; i < nums_task6.Length; i++)
            {
                Console.Write(nums_task6[i] + " ");
            }


            //task7
            Console.WriteLine("\n\n\nTask7. Evez olunan array: ");
            int[] nums_task7 = { 3, 6, 7, 1, 34, 8, 6, 19, 34 };
            int count_of_dublicates = 1;
            for (int i = 0; i < nums_task7.Length; i++)
            {
                for (int j = i + 1; j < nums_task7.Length; j++)
                {
                    if (nums_task7[i] == nums_task7[j])
                    {
                        nums_task7[j] = -1;
                        count_of_dublicates++;
                    }
                }
                if (count_of_dublicates > 1)
                {
                    nums_task7[i] = -1;
                }
                count_of_dublicates = 1;
            }
            for (int i = 0; i < nums_task7.Length; i++)
            {
                Console.Write(nums_task7[i] + " ");
            }
            Console.WriteLine("\n\n\n");








        }
    }
}
