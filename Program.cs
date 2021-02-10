using System;

namespace CS133PROJECT4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cake myCake = new Cake();

            myCake.Type = "Wedding Cake";
            myCake.AddFlavor<string>(" Vanilla");

            Cake myCake2 = new Cake();
            myCake2.Type = "Party Cake";
            myCake2.AddFlavor<string>(" Chocolate ");

        }
    }
}

public class Cake
{
    public string Flavor { get; set; }
    public string Type { get; set; }

    public void AddFlavor<C>(C flavor1)
    
    {
        this.Flavor = flavor1 as string;

        
    }




}