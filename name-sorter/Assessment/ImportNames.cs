using System;
using System.IO;
using System.Collections.Generic;

namespace SortingAssessment
{
    /*
      This code reads the names form the unsorted name file then supplies those name
      as a list of Persons.
     */
    public class ImportNames
    {
        public static List<Person> namesImported(string filename)
        {
            string incorrectNamesMessage = "The file was invalid.";
            // Reads the unsorted name file into an array of full names
            string[] readNames;

            try
            {
                readNames = File.ReadAllLines(filename);
            }
            catch (Exception e)
            {
                throw new IncorrectFileNameeException(incorrectNamesMessage, e);
            }
            // Passes the full names into people
            var people = new List<Person> { };
            for (int i = 0; i < readNames.Length; ++i)
            {
                var name = readNames[i];



                // Splits the full name string into first and last names at the last space character
                int lastspace = name.LastIndexOf(' ');
                if (lastspace < 1)
                {
                    throw new IncorrectFileNameeException(incorrectNamesMessage);
                }
                var firstNames = name.Substring(0, lastspace);
                var lastNames = name.Substring(lastspace + 1);

                people.Add(new Person(firstNames, lastNames));
            }

            return people;
        }
    }
}
