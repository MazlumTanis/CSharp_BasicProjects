using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProjects
{
    internal class DeleteChar
    {
       private string word;
       private int index;
       private string[] wordAndNumber;


        public void readVariables()
        {
            Console.WriteLine("Please enter a word and number seperate with comma ex=> Hello,3: ");
            word = Console.ReadLine();
            wordAndNumber = word.Split(',');
            index = Convert.ToInt32(wordAndNumber[1]);
            createWord(word, index);
        }
        public void createWord(string word,int index)
        {
            string newWord;
            StringBuilder sb = new StringBuilder(word);
            sb.Remove(index, 1);
            newWord = sb.ToString();
            Console.WriteLine(newWord);
        }
       


    }
}
