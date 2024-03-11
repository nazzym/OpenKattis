namespace countthevowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //read line of text of user
          string input = Console.ReadLine();
            // set (initialize) vowel count 
            int vowelCount = 0;
            //loop through each character in the input 
            foreach (char c in input) 
            { //check if the character is a vowel
            if (c =='A'|| c =='a'|| c =='E'|| c== 'e' || c == 'I'|| c== 'i'|| c=='O' || c == 'o'|| c == 'U'|| c == 'u')
                {  // if it is increment the vowel count
                    vowelCount++;
                }
            
            }   
            Console.WriteLine(vowelCount);
        }
    }
}
