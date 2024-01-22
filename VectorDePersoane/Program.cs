namespace VectorDePersoane
{
    internal class Program
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
            }
            
        }
    }
}
