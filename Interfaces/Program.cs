namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IntefacesIntro();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());
        }

        private static void IntefacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Mert",
                LastName = "Kasaci",
                Address = "Ankara"
            };


            Student student = new Student
            {
                Id = 1,
                FirstName = "Mert",
                LastName = "Kasaci",
                Address = "Ankara"
            };


            manager.Add(customer);
            manager.Add(student);
        }
    }
    //İsimlerdirme standardı olarak interface isimleri "I" karakteri ile başlar.
    //Interfacelerin en büyük kullanım amacı temel operasyon havuzu içeren bir arayüz oluşturup , başka sınıfların bunları implemenet edip
    //nesnelerine kullandırtmasıdır.
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }


    }

    //Bir interfaceyi implement eden classlar , o interfaceden gelen yapıları kendi bünyesinde barındırmak zorundadır.
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

    }

    class PersonManager
    {

        //public void Add(Customer customer)
        //{
        //    Console.WriteLine(customer.FirstName);
        //}

         public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }

    }
}