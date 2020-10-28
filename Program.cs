using System;
using System.Collections.Generic;

namespace Laab_11_Class_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Wilson = new Student("Wilson", "1234 Chester Street", "Science", 4, 800);

            Student Kylie = new Student("Kylie", "54321 Pontiac Blvd", "English", 2, 400);

            Student Rodney = new Student("Rodney", "86 Hathaway Rd", "History", 3, 600);

            Staff Sheryl = new Staff("Sheryl", "973 Reading Way", "Maple Elementary", 300);

            Staff Frank = new Staff("Frank", "1024 Hilltop Circle", "Birch High", 400);
            ;

            List<Person> Directory = new List<Person>
            {
            Wilson, Kylie, Rodney, Sheryl, Frank
            };



            foreach (Person person in Directory)
            {
                Console.WriteLine(person);
            }
                
            
        }
    }
}
