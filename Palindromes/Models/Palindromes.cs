using System;
using System.Linq;
using System.Collections.Generic;
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
  }
}