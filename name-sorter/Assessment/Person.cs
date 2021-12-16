using System;

namespace SortingAssessment
{
    /*
      A Person has one last name and a single string of their first names, thus, if they have a middle name,
      it will be treated part of the first name.
     */

    public class Person
    {
        public string firstNames { get; }
        public string lastName { get; }
        public Person(string firstNames, string lastName)
        {
            this.firstNames = firstNames;
            this.lastName = lastName;
        }

        public override string ToString() => $"{firstNames} {lastName}";

        public override bool Equals(object obj)
        {
            // If both objects are not of type Person, return false
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Person p = (Person)obj;

            return firstNames == p.firstNames && lastName == p.lastName;
        }

        public override int GetHashCode()
        {
            return firstNames.GetHashCode() * 97 + lastName.GetHashCode();
        }
    }

}

