//Завдання 3. Дано список: {1,2,3,1,4,5,2,2,1} Потрібно замінити повторювані числа (якщо число повторюється більше ніж 1 раз) на 0 всередині масиву (1) (3)
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Text.Json;
public class Program
{
    public static void Main()
    {
        List<int> list = new List<int> { 1, 2, 3, 1, 4, 5, 2, 2, 1 };

        List<int> end = list.Take(3).ToList();
        end.Add(0);
        List<int> end2 = list.Skip(4).Take(2).ToList();
        end2.Add(0);
        end2.Add(0);
        end2.Add(0);

        list = Enumerable.Concat(end, end2).ToList();
        foreach (int item in list)
        {
            Console.Write(item + " ");
        }

    }

}

