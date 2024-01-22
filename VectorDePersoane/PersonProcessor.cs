using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDePersoane
{
    public static class PersonProcessor
    {
        public static Person GetPerson(Person[] persons)
        {
            if(persons is null) 
            {
                throw new ArgumentNullException(nameof(persons), "Cannot process a null reference.");
            }

            int maxAge = -1;
            int maxIndex = -1;

            for (int i = 0; i < persons.Length; i++) 
            {
                if (persons[i].Age > maxAge)
                {
                    maxAge = persons[i].Age;
                    maxIndex = i;
                }
            }

            if (maxIndex < 0)
            {
                throw new IndexOutOfRangeException($"{nameof(persons)} is a void array.");
            }

            return persons[maxIndex];
        }
    }
}
