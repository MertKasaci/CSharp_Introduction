namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Mert"},
                new Student{FirstName="Mert"},
                new Person{FirstName="Mert"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    //class Person2
    //{

    //}

    class Customer : Person //, Person2 --> Çoklu kalıtıma .Net tarafından izin verilmez.
    {

        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}