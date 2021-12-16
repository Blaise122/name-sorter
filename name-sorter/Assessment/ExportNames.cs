using System;
using System.Collections.Generic;
using System.IO;


namespace SortingAssessment
{
    /*
      Writes a list of names to a sorted-names-list.txt file and to console.
     */
    public class ExportNames
    {
        public static void exportNames(List<Person> people)
        {
            try
            {
                // Write to sorted-names-list.txt file
                using (System.IO.StreamWriter file = new StreamWriter("sorted-names-list.txt"))
                {
                    foreach (Person person in people)
                    {
                        file.WriteLine(person);
                        Console.WriteLine(person);
                    }
                }
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Was unable to write to the file.");
            }
        }
    }
}
