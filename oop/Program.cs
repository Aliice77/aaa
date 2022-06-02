using System;

namespace oop

{

public class Customer {
private int _costom;
public int costom
{
    get { return _costom; }
    set { _costom = value; }
}
private int myVar;
public int MyProperty
{
    get { return myVar; }
    set { myVar = value; }
}

public int aa(){
                int b=costom*MyProperty*30*24;
            Console.WriteLine(b);
            return b;
}
}
    class Program
    {
        static void Main(string[] args)
        {
            Customer objCustomer = new Customer();
            Console.Write("enter hoghogh: ");
            objCustomer.costom=Convert.ToInt32( Console.ReadLine());
            Console.Write("enter mah: ");
            objCustomer.MyProperty=Convert.ToInt32( Console.ReadLine());
            objCustomer.aa();
        }
    }
}
