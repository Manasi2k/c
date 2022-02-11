using System;
class ReadKey {
  public static void Main(string[] args)
  {
    ConsoleKeyInfo k = Console.ReadKey();
    Console.WriteLine("You pressed: "+ k.Key);
   
  }
}