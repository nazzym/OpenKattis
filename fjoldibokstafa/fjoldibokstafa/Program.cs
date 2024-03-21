namespace fjoldibokstafa
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            
                //read line of text of user
                string input = Console.ReadLine();
                // set (initialize) vowel count 
                int letterCount = 0;
               
                //loop through each character in the input 
                foreach (char c in input)
                { //check if the character is a vowel
                    if (char.IsLetter(c)) 
                {  
                    letterCount++;
                }
                    
                
                }
                Console.WriteLine(letterCount);


            
        }
    }
}
    

