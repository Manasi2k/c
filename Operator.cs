using System;
class Number {
  public static void Main() {
      Console.WriteLine ("Enter any two numbers");
      int num1, num2;
        
        num1 = Convert.ToInt32 (Console.ReadLine());
        num2 = Convert.ToInt32 (Console.ReadLine());
        Console.WriteLine ("Addition of two numbers is:" + (num1 + num2));
        Console.WriteLine ("Substraction of two numbers is:" + (num1 - num2));
        
  }
}
