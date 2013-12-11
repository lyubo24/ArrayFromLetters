﻿using System;
using System.Linq;


namespace _12.ArrayFromLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.



              char[] arr = new char[52];
              for (int i = 0; i < arr.Length; i++)  
              {
                  if (i < 26)
                  {
                      arr[i] = (char)('A' + i);
                  }
                  else
                  {
                      arr[i] = (char)('a' + (i - arr.Length / 2));
                  }
              }

              for (int i = 0; i < arr.Length; i++)
              {
                  Console.WriteLine("{0}. {1}", 1 + i, arr[i]);
              }

              Console.Write("Please enter the word: ");
              string word = Console.ReadLine(); 
              for (int i = 0; i < word.Length; i++)
              {
                  int temp = Convert.ToInt32(word[i] - 'A');
                  Console.WriteLine("{0} <-> {1}", word[i], temp + 1 < 27 ? temp + 1 : temp - 5);
              }



          

        }
    }
}
