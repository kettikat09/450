//Завдання 1. Дано список List <T> з об'єктами одного типу Obj, у якого в свою чергу є властивість Id.
//Організувати пошук для знаходження елемента колекції по його властивості

using System.Text.Json;
public class Program
{
    public static void Main()
    {
        List<Person> person = new List<Person>();
        for (int i = 0; i < 5; i++)
            person.Add(new Person());
        foreach (var item in person)
        {
            Console.WriteLine(item.Id);
        }
        Console.Write($"insert Id: ");
        int SearchID = int.Parse(Console.ReadLine());
        Person p = person.Find(x => x.Id == SearchID);
        int idindex = person.IndexOf(p);
        if (idindex != -1)
            Console.WriteLine(idindex);
        else
            Console.WriteLine("ID not found");
    }
}
public class Person
{
    public int Id;
    public Person() { Random random = new Random(); Id = random.Next(1000, 10000); }
}
