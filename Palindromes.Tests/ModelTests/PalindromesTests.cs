using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes;
using System;

namespace Palindromes.Tests
{
  [TestClass]
  public class ClassNameTests
  {
    // Test methods go here
    [TestMethod]
    public void LowerCase_ChangeToLowerCase_bob()
    {
      PalChecker testPalChecker = new PalChecker();
      Assert.AreEqual("bob",testPalChecker.LowerCase("BOB"));
    }
    [TestMethod]
    public void ToArray_ChangeToArray_CharArray()
    {
      PalChecker testPalChecker = new PalChecker();
      string input = "bob";      
      char[] array = input.ToCharArray();
       CollectionAssert.AreEqual(array,testPalChecker.ToArray(input));      
    }
    [TestMethod]
    public void ReverseArray_WillReverseCharArray_ReversedArray()
    {
      PalChecker testPalChecker = new PalChecker();
      string input = "bob";      
      char[] array = input.ToCharArray();
      Array.Reverse(array);
      CollectionAssert.AreEqual(array,testPalChecker.ToArray(input));
    }
    [TestMethod]
    public void CompareArray_WillCompareCharArray_true()
    {
      PalChecker testPalChecker = new PalChecker();
      string input = "12021";      
      char[] array = input.ToCharArray();
      char[] revArray = input.ToCharArray();
      Array.Reverse(revArray);
      Assert.AreEqual(true,testPalChecker.CompareArrays(array, revArray));
    }

    [TestMethod]
    public void Palindro_WillLowercaseAndChangeArray_CharArray()
    {
      PalChecker testPalChecker = new PalChecker();
      // string input = "bob";
      // char[] array = input.ToCharArray();
      // CollectionAssert.AreEqual(array,testPalChecker.Palindro("BOB"));
      Assert.AreEqual(true,testPalChecker.Palindro("Racecar"));
    }
  }
}