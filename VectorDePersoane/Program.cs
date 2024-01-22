namespace VectorDePersoane
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of persons: ");
            string? numberOfPersonsAsString = Console.ReadLine();
            bool isOk = int.TryParse(numberOfPersonsAsString, out int numberOfPersons);

            if (isOk) 
            {
                Person[] persons = new Person[numberOfPersons];
                for (int i = 0; i < numberOfPersons; i++)
                {
                    Console.WriteLine($"Enter the data of Person[{i}]");
                    Console.Write("Enter the first name: ");
                    string? personFirstName = Console.ReadLine();
                    Console.Write("Enter the last name: ");
                    string? personLastName = Console.ReadLine();
                    Console.Write("Enter the year of birth: ");
                    string? yearOfBirthAsString = Console.ReadLine();
                    bool isNumber = int.TryParse(yearOfBirthAsString, out int result);

                    if (isNumber) 
                    {
                        persons[i] = new Person(personFirstName, personLastName, result);
                    }
                }

                Person maxAgePerson = PersonProcessor.GetPerson(persons);
                PrintPerson(maxAgePerson);
            }
            
        }

        public static void PrintPerson(Person person)
        {
            Console.WriteLine($"FirstName: {person.FirstName}");
            Console.WriteLine($"LastName: {person.LastName}");
            Console.WriteLine($"YearOfBirth: {person.YearOfBirth}");
            Console.WriteLine($"Age: {person.Age}");
        }
    }
}
