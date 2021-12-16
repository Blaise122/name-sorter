using System;
using System.Collections.Generic;
using SortingAssessment;
using Xunit;

namespace SortingAssessmentSort
{
    public class SortTester
    {
        [Fact]
        public void simpleSortTest()
        {
            var firstNames = new List<string> {
                "Janet",
                "Vaughn",
                "Adonis Julius",
                "Shelby Nathan",
                "Marin",
                "London",
                "Beau Tristan",
                "Leo",
                "Hunter Uriah Mathew",
                "Mikayla",
                "Frankie Conner"
            };
            var lastNames = new List<string> {
                "Parsons",
                "Lewis",
                "Archer",
                "Yoder",
                "Alvarez",
                "Lindsey",
                "Bentley",
                "Gardner",
                "Clarke",
                "Lopez",
                "Ritter"
            };
            var unsorted = personListMaker(firstNames, lastNames);
            var testSorted = Sorter.sort(unsorted);

            var sortedFirstNames = new List<string> {
                "Marin",
                "Adonis Julius",
                "Beau Tristan",
                "Hunter Uriah Mathew",
                "Leo",
                "Vaughn",
                "London",
                "Mikayla",
                "Janet",
                "Frankie Conner",
                "Shelby Nathan"
            };
            var sortedLastNames = new List<string> {
                "Alvarez",
                "Archer",
                "Bentley",
                "Clarke",
                "Gardner",
                "Lewis",
                "Lindsey",
                "Lopez",
                "Parsons",
                "Ritter",
                "Yoder"
            };
            var correctSorted = personListMaker(sortedFirstNames, sortedLastNames);
            Assert.Equal(correctSorted, testSorted);
        }
        private List<Person> personListMaker(List<string> firstNames, List<string> lastNames)
        {
            var people = new List<Person> { };
            for (int i = 0; i < firstNames.Count; ++i)
            {
                people.Add(new Person(firstNames[i], lastNames[i]));
            }
            return people;
        }
    }
}