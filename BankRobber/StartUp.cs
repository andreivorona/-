namespace BankRobber
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Please add number of witnesses");

            int numberOfPersons = int.Parse(Console.ReadLine());

            List<string> namesOfwitnesses = new List<string>();

            List<string> indicationsOfwitnesses = new List<string>();

            List<string> notGuilty = new List<string>();

            for (int i = 0; i < numberOfPersons; i++)
            {
                Console.WriteLine("Please add name of witnes");

                string nameOfwitnes = Console.ReadLine();

                Console.WriteLine("Please add indication of witnes");

                string indicationOfwitnes = Console.ReadLine();

                namesOfwitnesses.Add(nameOfwitnes);

                indicationsOfwitnesses.Add(indicationOfwitnes);
            }

            for (int i = 0; i < namesOfwitnesses.Count; i++)
            {
                for (int j = 0; j < indicationsOfwitnesses.Count; j++)
                {
                    if (indicationsOfwitnesses[j].Contains(namesOfwitnesses[i]))
                    {
                        notGuilty.Add(namesOfwitnesses[i]);

                        notGuilty.Add(namesOfwitnesses[j]);
                    }
                }
            }

            foreach (string name in notGuilty)
            {
                namesOfwitnesses.Remove(name);
            }

            if (namesOfwitnesses.Count == 1)
            {
                Console.WriteLine($"The guilty is: {namesOfwitnesses[0]}");
            }

            else if (namesOfwitnesses.Count == numberOfPersons)
            {
                Console.WriteLine($"The guilty is: {namesOfwitnesses[0]}");
            }

            else if (namesOfwitnesses.Count == 0)
            {
                Console.WriteLine($"The guilty is: {notGuilty[0]}");
            }
        }
    }
}
