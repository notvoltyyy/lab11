using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        SaintNicholas saintNicholas = SaintNicholas.Instance;
        Console.WriteLine("Enter number of children: ");
        if (int.TryParse(Console.ReadLine(), out int childNum) && childNum > 0)
        {
            for (int i = 0; i < childNum; i++)
            {
                Console.WriteLine($"Enter details for child {i + 1}:");

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Good things: ");
                int goodDeeds = int.Parse(Console.ReadLine());
                Console.Write("Bad things: ");
                int badDeeds = int.Parse(Console.ReadLine());

                saintNicholas.AddChild(new Child(name, goodDeeds, badDeeds));
            }
            saintNicholas.SendGifts();
        }
        else
        {
            Console.WriteLine("Invalid num.");
        }
    }
}