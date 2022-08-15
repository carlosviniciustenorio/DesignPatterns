using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        //-----------------------------------------------
        //Shallow Copy = A referência de memória pro objeto foi copiada
        // Customer customer1 = new("Customer1");
        // Customer customer2 = customer1;

        // customer2.Name = "Customer2";
        // Console.WriteLine($"Customer 1: {customer1.Name}");
        // Console.WriteLine($"Customer 2: {customer2.Name}");

        // Console.ReadLine();
        //-----------------------------------------------
        
        //-----------------------------------------------
        //O método Clone padrão da interface só clona propriedades dos tipos primitivos, diferente de propriedades complexas (Referências de Objetos)
        // CustomerWithPrototype customer1 = new("Customer1", new("Street customer1", 1));
        // CustomerWithPrototype customer2 = (CustomerWithPrototype)customer1.Clone();

        // customer2.Name = "Customer2";
        // customer2.Adress.Street = "Street customer 2";
        // Console.WriteLine($"Customer 1: {customer1.Name}");
        // Console.WriteLine($"Street Customer 1: {customer1.Adress.Street}");
        // Console.WriteLine($"Customer 2: {customer2.Name}");
        // Console.WriteLine($"Street Customer 2: {customer2.Adress.Street}");

        // Console.ReadLine();
        //-----------------------------------------------
        CustomerWithPrototype customer1 = new("Customer1", new("Street customer1", 1));
        CustomerWithPrototype customer2 = (CustomerWithPrototype)customer1.Clone();

        customer2.Name = "Customer2";
        customer2.Adress.Street = "Street customer 2";
        Console.WriteLine($"Customer 1: {customer1.Name}");
        Console.WriteLine($"Street Customer 1: {customer1.Adress.Street}");
        Console.WriteLine($"Customer 2: {customer2.Name}");
        Console.WriteLine($"Street Customer 2: {customer2.Adress.Street}");

        Console.ReadLine();
        //-----------------------------------------------

    }
    public class Customer{
        public Customer(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }    

    [Serializable]
    public class CustomerWithPrototype : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Adress Adress { get; set; }
        public CustomerWithPrototype(string name, Adress adress)
        {
            Name = name;
            Adress = adress != null ? adress : new();
        }

        // public object Clone() => this.MemberwiseClone();

        public object Clone()
        {
            var thisSerialize = JsonSerializer.Serialize(this);

            return JsonSerializer.Deserialize<CustomerWithPrototype>(thisSerialize);
            
        }
    }
    
    public class Adress
    {
        public int Id { get; set; }
        public string Street {get; set;}
        public int Number { get; set; }
        public Adress(string street, int number)
        {
            Street = street;
            Number = number;
        }

        public Adress(){}
    }
}