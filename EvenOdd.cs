using System;
class Number {
  public static void Main() {
      int num;
        Console.WriteLine ("Enter any number");
        num = Convert.ToInt32 (Console.ReadLine());
        if(num % 2==0)
        Console.WriteLine ("number is even");
        else
        Console.WriteLine ("Number is odd");
        
  }
}
