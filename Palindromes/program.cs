using System;

namespace Palindromes
{   public class Program
  {
    public static void Main() 
    {      
      PalChecker pCheck = new PalChecker();
      Console.WriteLine(pCheck.Palindro2("RACECAR"));
    }
  }
}
