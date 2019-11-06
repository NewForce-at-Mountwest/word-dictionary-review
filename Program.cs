using System;
using System.Collections.Generic;

namespace dictionaries_review {
    class Program {
        static void Main (string[] args) {
            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>> ();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few word
            Dictionary<string, string> excitedWord = new Dictionary<string, string> ();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example sentence", "I am excited to learn C#!");

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(excitedWord);
            // create another Dictionary and add that to the list
            Dictionary<string, string> sadWord = new Dictionary<string, string>();

            sadWord.Add("word", "sad");
            sadWord.Add("definition", "feelin bad");
            sadWord.Add("part of speech", "adjective");
            sadWord.Add("example sentence", "sometimes windows makes me sad");

            dictionaryOfWords.Add(sadWord);
            /*
                Iterate your list of dictionaries and output the data

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> singleWord in dictionaryOfWords) {
                // Iterate the KeyValuePairs of the Dictionary
                Console.WriteLine();
                foreach (KeyValuePair<string, string> wordData in singleWord) {
                    Console.WriteLine ($"{wordData.Key}: {wordData.Value}");
                }
            }
        }
    }
}