using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inputtotalrose: " );
            Console.ReadLine();
            Console.WriteLine("inputtotalsunflower: ");
            Console.ReadLine();
            printroseinformation();
            printSunflowerinfromation();

        }
        static void printroseinformation()
        {
            rose rose = new rose(1,"กุหลาบ","โสยงงามมาก",2,"10.2","6");

            
        }
        static void printSunflowerinfromation()
        {

        }


    }
}
class allflower
{
    public int id;
    public string name;
    public string description;
    public int amount;
    public string Height;
    public string Circumference;

    public allflower(int id,string name ,string description, int amount ,string Height,string Circumference)
    {
        this.id = id;
        this.name = name;
        this.description = description;
        this.amount = amount;
        this.Height = Height;
        this.Circumference = Circumference;
    }

}
class rose: allflower 
{
    public rose (int id,string name, string description, int amount, string Height, string Circumference):base(id,name,description,amount,Height,Circumference)
    {
        this.id = id;
        this.name = name;
        this.description = description;
        this.amount = amount;
        this.Height = Height;
        this.Circumference = Circumference;
    }
}
class Sunflower : allflower
{

    public Sunflower(int id,string name, string description, int amount, string Height, string Circumference) : base(id,name, description, amount, Height, Circumference)
    {
        this.id = id;
        this.name = name;
        this.description = description;
        this.amount = amount;
        this.Height = Height;
        this.Circumference = Circumference;
    }
}

   
    