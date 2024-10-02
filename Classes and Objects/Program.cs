using System; // Classes and Objects
class Person
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Person p = new Person();
        p.Name = "John Doe";
        Console.WriteLine("Person's Name: {0}", p.Name);
    }
}