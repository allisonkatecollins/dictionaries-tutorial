//DO NOT RELY ON ORDER OF ITEMS IN A DICTIONARY

using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> languagesWithScore = new Dictionary<string, int>() {
              {"English", 4},
              {"Spanish", 0},
              {"C#", 4}
            };

            languagesWithScore.Add("JavaScript", 3);

            //kvp is acronym for key value pair
            foreach(KeyValuePair<string, int> kvp in languagesWithScore) {
              Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
            }

            Console.WriteLine("--------------");

            //change score
            languagesWithScore["Spanish"] = 1;

            //add new language
            languagesWithScore["French"] = 5;
            foreach(KeyValuePair<string, int> kvp in languagesWithScore) {
              Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
            };

            Console.WriteLine("---------------");
            int frenchScore = languagesWithScore["French"];
            Console.WriteLine($"French: {frenchScore}");

            List<Dictionary<string, int>> langScoreList = new List<Dictionary<String, int>>();
            langScoreList.Add(languagesWithScore);

            Dictionary<string, int> languagesWithScore2 = new Dictionary<string, int>(){
              {"English", 5}
            };

            langScoreList.Add(languagesWithScore2);

            Console.WriteLine("---printing langScoreList---");
            foreach(Dictionary<string, int> lang in langScoreList) {
              PrintDictionary(lang);
            }
            Console.WriteLine("---end langScoreList---");

            if (languagesWithScore.ContainsKey("French")) {
              Console.WriteLine("YAY");
            } else {
              Console.WriteLine("BOO");
            }

            if (languagesWithScore.ContainsValue(2)) {
              Console.WriteLine("YAY");
            } else {
              Console.WriteLine("BOO");
            }

            //dictionary inside of a dictionary
            Dictionary<string, Dictionary<string, int>> people =
              new Dictionary<string, Dictionary<string, int>>() {
                {
                  "Hunter",
                  new Dictionary<string, int>() { {"French", 5} }
                }, {
                  "Jordan",
                  new Dictionary<string, int>() { {"Spanish", 5}, {"English", 5}}
                }
              };
        }
        //outside scope of Main, can go either before or after - works the same
        static void PrintDictionary(Dictionary<string, int> dict) 
        {
          foreach(KeyValuePair<string, int> kvp in dict) 
          {
            Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
          }
        }
    }
}
