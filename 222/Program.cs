//Завдання 2. Видалити зі словника елементи з однаковими значеннями. Записати результат у JSON файл.

using Newtonsoft.Json;
using System;
using System.Text.Json;
public class Program
{
    public static void Main()
    {
        Dictionary<int, int> elements = new Dictionary<int, int>();
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            elements.Add(i, random.Next(0, 5));
            Console.Write(elements[i]+"\t");
        }
        Console.WriteLine("-----------"); 
        List<int> list = new List<int>();
        List<int> listkey = new List<int>();
        foreach (int i in elements.Keys)
        {
            if (!list.Contains(elements[i]))
            {
                list.Add(elements[i]);
                listkey.Add(i);
            }
        }
        elements.Clear();
        for (int i = 0; i<list.Count; i++)
        {
            elements.Add(listkey[i], list[i]);
        }
        foreach (var i in elements)
        {
            Console.WriteLine(i.Key + " " + i.Value);
        }
        string JSon = JsonConvert.SerializeObject(elements);

        Console.WriteLine(JSon);


    }


}
