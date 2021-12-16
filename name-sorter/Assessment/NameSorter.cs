using System;

namespace SortingAssessment
{
    /**
     Main page of the programme that takes an argument of a path to a file
     containing a list of unsorted names and sorts them alphabetically, first by last name, then by first names.
     It then outputs the sorted list to console and to a file in the working directory.
     */
    class NameSorter
    {
        static void Main(string[] args)
        {
            // Testing if input arguments were supplied.
            if (args.Length != 1)
            {
                Console.WriteLine(args);
                Console.Error.WriteLine("Incorrect number of argument.");
                return;
            }
            else
            {
                var filename = args[0];
                var unsorted = ImportNames.namesImported(filename);
                var sorted = Sorter.sort(unsorted);
                Console.WriteLine(filename);
                ExportNames.exportNames(sorted);
            }




        }
    }
}

