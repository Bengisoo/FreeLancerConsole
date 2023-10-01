// See https://aka.ms/new-console-template for more information
using FreeLanceConsole.Entities;
using FreeLanceConsole.Services;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Hello, World!");

//string path= Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

//File.WriteAllText($"{path}\\Deneme.txt", "deneme");

/**Customer customer1 = new Customer()
{
    Id= Guid.NewGuid(),
    CreatedOn= DateTime.Now,
    FirstName="deniz",
    LastName="yıldız",
    PhoneNumber="551 552 79 97"
}; */

/**var FreeLancerInstance = new FreeLancer()
{
    Id = Guid.NewGuid(),
    CreatedOn = DateTime.Now,
    FirstName = "deniz",
    LastName = "yıldız",
    WorkExperience = "5 years experience in web development",
    Reviews = new List<Review>
    {
         new Review { Text = "Excellent Freelancer!", Rating = 5 },
         new Review  { Text = "Greak Work", Rating = 4 }

    } 
}; */

var customer1 = new Customer()
{
    Id = Guid.NewGuid(),
    CreatedOn = DateTime.Now,
    FirstName = "deniz",
    LastName = "yıldız",
    PhoneNumber = "505-678-2988",

};

NotepadService notepad = new();
//notepad.SaveToNotepad(FreeLancerInstance);

string CustomerData = 
   notepad.GetOnNotepad("C:\\Users\\zehra\\source\\repos\\FreeLanceConsole\\FreeLanceConsole\\Database\\Customers.txt");

string[] splittedLines = CustomerData.Split("\n", StringSplitOptions.RemoveEmptyEntries);

List<Customer> customers = new();

foreach(var line in splittedLines)
{
    Customer customer = new();
    customer.SetValuesCSV(line);
    customers.Add(customer);
}

foreach(var customer in customers)
{
    Console.WriteLine(customer.FirstName);
}
