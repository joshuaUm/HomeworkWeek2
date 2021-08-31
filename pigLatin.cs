/// Homework No. 2		Project No. 1
/// File Name: pigLatin.cs
/// @author: Joshua Um
/// Date:  August 30, 2021
///
/// Problem Statement: Take my full name (two strings) and convert it to pig latin, then /// display full name.
/// 
/// 
/// Overall Plan:
/// 1. Declare two strings variables for first and last name.
/// 2. convert first name to pig latin by moving first letter to end of name (in lowercase)
/// adding "ay" at the end of the name, then uppercase first letter of name.
/// 3. Repeat step 2 with last name.
/// 4. Print full name.


using System;

class Program {
  public static void Main (string[] args) {
    string first = "Joshua",last = "Um", pigLatin_first, pigLatin_last, pigLatin_name;

    pigLatin_first =  first.Substring(1,1).ToUpper()  + first.Substring(2) + first.Substring(0,1).ToLower() + "ay";

    pigLatin_last = last.Substring(1,1).ToUpper()  + last.Substring(2) + last.Substring(0,1).ToLower() + "ay";

    pigLatin_name = pigLatin_first + " " + pigLatin_last;

    Console.WriteLine("{0} in Pig Latin : {1} " , first + " "  + last, pigLatin_name);
  }
}