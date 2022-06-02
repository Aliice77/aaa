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
public int aa(){
                int b=costom*7;
            Console.WriteLine(b);
            return b;
}
}
    class Program
    {
        static void Main(string[] args)
        {
            Customer objCustomer = new Customer();
            objCustomer.costom=Convert.ToInt32( Console.ReadLine());
            objCustomer.aa();
        }
    }
}
