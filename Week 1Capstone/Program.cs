using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1Capstone
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Welcome to the Pig Latin Translator!");
                Console.WriteLine("Enter a word to be translated");
                {
                    string word = Console.ReadLine().ToLower();
                    string vowels = "aeiou";

                    if (word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u')

                    {
                        Console.WriteLine(word + "way");

                    }
                    else
                    {

                        for (int i = 0; i < word.Length; i++)
                        {
                            for (int j = 0; j < vowels.Length; j++)

                                if (word[i] == vowels[j])
                                {
                                    //do code stuff
                                    string end = word.Substring(i, word.Length - i);
                                    string start = word.Substring(0, i);
                                    Console.WriteLine(end + start + "ay");
                                    i = word.Length;
                                    j = vowels.Length;


                                }




                        }
                    }


                }

                ////grabbing the first two letters
                //word = word.Substring(0, 2);

                //    //grabbing only the last letter
                //    string end = data.Substring((data.Length - 1), 1);

                ////concat to make a new string
                //data = start + end + "123456";
                //    data = data + start;


                //    string hello = "hello world";

                ////how to split string into separate words
                //string[] stringArray = hello.Split(' ');

            }
        }
    }
}

