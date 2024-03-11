

namespace shandy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int beer = int.Parse(Console.ReadLine());
            int lemonade = int.Parse(Console.ReadLine());
            int i = 0;
            int count = 0;//Math.Min(input, number);

            
                if (beer < lemonade  )
                {
                Console.WriteLine(beer * 2);
                }
                else if( lemonade < beer ) 
            {
            
            Console.WriteLine(lemonade*2);
            }
                else if ( beer == lemonade ) 
            
            {
            
            Console.WriteLine(beer*2);
            }

            
               
               
                    
        }
    }
}