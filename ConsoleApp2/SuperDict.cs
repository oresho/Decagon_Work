using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp2
{
    internal class SuperDict
    {
        public string GetTranslation(string EnglishWord, string Language)
        {
            Dictionary<string, Dictionary<string, string>> superDictionary = new();

            Dictionary<string, string> IgboDictionary = new()
            {
                { "Hello", "Ndewo" },
                {"Come", "Bia" }
            };

            Dictionary<string, string> YorubaDictionary = new()
            {
                { "Hello", "Mo ki o" },
                {"Come", "Wa" }
            }; 
              
            Dictionary<string, string> HausaDictionary = new()
            {
                { "Hello", "Sannu" },
                {"Come", "Zo" }
            };

            superDictionary.Add("Igbo", IgboDictionary);
            superDictionary.Add("Yoruba", YorubaDictionary);
            superDictionary.Add("Hausa", HausaDictionary);

            if (!superDictionary.ContainsKey(Language)) return "This Language is not supported";
            Dictionary<string, string> LanguageDictionary = superDictionary[Language];

            if (LanguageDictionary.ContainsKey(EnglishWord))
            {
                return $"The {Language} translation for {EnglishWord} is: {LanguageDictionary[EnglishWord]}";
            }
            else
            {
                return $"Sorry this dictionary doesn't have the word {EnglishWord} in it";
            }
        }
    }
}
