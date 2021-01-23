using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Eren");

            Console.WriteLine(names.Length);

            names.Add("Erdem");

            Console.WriteLine(names.Length);

            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }
        } 
    }
}
