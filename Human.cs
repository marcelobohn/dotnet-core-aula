using System;
class Human {
    public bool validate() {
        Random rnd = new Random();
        int n1 = rnd.Next(1,6);
        int n2 = rnd.Next(1,6);
        System.Console.WriteLine($"{n1} + {n2} = ?");
        string r = Console.ReadLine();         
        return n1+n2 == Convert.ToInt32(r);
    }   
}