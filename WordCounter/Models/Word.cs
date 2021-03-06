using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter 
  {
    public string WordInput { get; set; }
    public string SentenceInput { get; set; }
    public static string[] wordList = System.IO.File.ReadAllLines(@"C:\Users\Cadwell\Desktop\wordcounter\WordCounter\Models\WordList.txt");

    public void AddWord(string userWord)
    {
      WordInput = userWord;
    }
    public void AddSentence(string userSentence)
    {
      SentenceInput = " " + userSentence + " ";
    }
    public static string[] SentenceToArray(string userSentence)
    {
      string[] sentenceArray = userSentence.Split(" ");
      return sentenceArray;
    }
    public bool ContainsWord()
    {
      return SentenceInput.Contains(WordInput);
    }
    public int WordRepeatCount()
    {
      string[] sentenceArray = SentenceToArray(SentenceInput);
      int wordCount = 0;
      foreach(string word in sentenceArray)
      {
        string newWord =word.ToLower();
        if (newWord == WordInput)
        {
          wordCount += 1;
        }
      }
      return wordCount;
    }
    public static bool IsAWord(string userInput)
    {
      if (userInput.Contains(" "))
      {
        return false;
      }
      foreach (string entry in wordList)
      {
        if (entry.Contains(userInput))
        {
          return true;
        }     
      }
      return false;
    }
  }
} 