
class Program
{
    static int Main(string[] args)
    {
        Person prs = new Person("Taras", "Semeniv", "0001", 18, 1000);
        prs.withdraw(500);
        prs.show_info();
        return 0;
    }
}
class Person
{
    string name, surname, ID;
    int age, balance;
    public Person(string name, string surname, string ID, int age, int balance)
    {
        this.name = name;
        this.surname = surname;
        this.ID = ID;
        this.age = age;
        this.balance = balance;
    }
    public void withdraw(int value)
    {
        if (value >= balance)
        {
            Console.WriteLine("The value canot be greater than the balance");
        }
        else
        {

        }
    }
    public void show_info()
    {
        Console.WriteLine($"Name: {name}\nSurname: {surname}\nID: {ID}\nAge: {age}\nBalance: {balance}");
    }
}