using System;

class Program {

  public static int IntegerPower (int num1, int num2)
    {
      int total = 1;
      for (int i = 0; i < num2; i++)
        {
        total *= num1;
        }

      return total;
    }
  public static void Main (string[] args) 
    {

    int e = 0;
    
    Console.WriteLine("Enter a base and an exponent (base,exponent)");

    e = IntegerPower(2,12);
    Console.WriteLine(e);


   }



}