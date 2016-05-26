using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace penualtimate_word_codeEval
{
    class Program
    {
        static void Main(string[] args)
        {
            //pull the 2nd to last word out
            string line = "some line with text";

             string[] word = line.Split();

            Console.WriteLine(word[word.Length - 2]);

            



        }
    }
}
