using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProjects
{
    internal class ReverseText
    {
       

            public void reverseText()
            {
                String text;
                Console.Write("Please enter the Text: ");
                text = Console.ReadLine();
                char[] charArray = text.ToCharArray();
                Array.Reverse(charArray);
                Console.WriteLine(charArray);
            }
        
    }
}
