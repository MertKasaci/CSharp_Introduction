namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Class yapısı nesnel programlamanın en temel unsurlarından biridir.

            //Genel anlamda class yapısını yapmak istediğimiz işlemleri gruplara ayırmak , o grup üzerinden işlemlerimizi yapmak ve rahatlıkla bu gruba
            //ulaşmak için kullanabiliriz.

            //Bir classı kullabilmek için aşağıdaki gibi örneğini oluşturmalıyız.
            //Classı Pascal Case , ondan oluşturacağımız örneği Camel Case yöntemiyle oluşturmak best practicedır.
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            //Customer sınıfına ait bir nesne oluşturduk.
            //Daha sonra bu nesneye ait propertlyere değerler atadık.
            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Mert";
            customer.LastName = "Kasacı";

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "İstanbul",
                FirstName = "Mert",
                LastName = "Kasacı"
            };

            Console.WriteLine(customer2.FirstName); //dot notation ile o nesneye ait propertnin içinde tutulan veriye ulaşabiliyoruz.

        }
    }

    
  
   
}