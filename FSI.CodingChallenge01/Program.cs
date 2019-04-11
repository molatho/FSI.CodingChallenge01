using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("{0} von deinen {1} Steinen sind Edelsteine!", "aA".Sum(e => "aAAbbbb".Count(s => s == e)), "aAAbbbb".Length);
    }
}