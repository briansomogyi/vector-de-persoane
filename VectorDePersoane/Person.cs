﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDePersoane
{
    public class Person
    {
        public Person(string firstName, string lastName, int yearOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;
            Age = DateTime.Now.Year - YearOfBirth;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int YearOfBirth {  get; set; }

        public int Age { get; set; }
    }
}
