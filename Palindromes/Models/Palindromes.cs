using System;
using System.Linq;
namespace Palindromes
{
  public class PalChecker
  {
    // properties, constructors, methods, etc. go here
    public string LowerCase(string input)
    {
      return input.ToLower();
    } 

    public char[] ToArray(string input)
    {
     char[] array = input.ToCharArray();     
     return array;
    }

    public char[] ReverseArray(char[] input)
    {
      Array.Reverse(input);
      return input;
    }
    public bool CompareArrays(char[] input, char[] input1)
    {      
      input.SequenceEqual(input1);      
      return input.SequenceEqual(input1);
    }
    public bool Palindro(string input)
    {
      char[] array = input.ToLower().ToCharArray();
      char[] revArray = new char[array.Length];
      Array.Reverse(revArray); // REPLACE???
      return array.SequenceEqual(revArray);
    }

    public bool Palindro2(string input)
    {      
      char[] array = input.ToLower().ToCharArray();      
      string revString = "";
      for (int i = array.Length-1; i>=0; i--)
      {        
        revString += array[i].ToString();
      }      
      return (input.ToLower() == revString);
    }    
  }  
}