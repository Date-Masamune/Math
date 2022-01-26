using System;

namespace Circle
{
    class circle { 
      

      static void Main(string[] args)
      {

         float MyPi = 3.14159f;
         int r;
         
         Console.WriteLine("Enter Radius"); //prompt user
         // read diameter from user
         r = int.Parse(Console.ReadLine());

         Console.WriteLine($"Diameter = {2 * r}");
         Console.WriteLine($"Circumference = {2 * MyPi * r}");
         Console.WriteLine($"area = {MyPi * r * r}");
         // This a pull test
      }
   }
}

