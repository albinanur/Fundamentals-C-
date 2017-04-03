using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
                      
            for(int r = 1; r <=255; r++)
            {
                Console.WriteLine(r);
            }
            for(int i = 1; i <=100; i++)
            {
                if(i%3==0 && i%5!=0)
                {
                Console.WriteLine(i);
                }
                
                else if(i%5==0 && i%3!=0)
                {
                   Console.WriteLine(i);  
                }
                   
                 
               
            }
            for(int i = 1; i <=100; i++)
            {
                if(i%3==0 && i%5!=0)
                {
                Console.WriteLine("Fizz");
                }
                
                else if(i%5==0 && i%3!=0)
                {
                   Console.WriteLine("Buzz");  
                }
                else if(i%5==0 && i%3==0)
                {
                   Console.WriteLine("FizzBuzz");  
                }
                   
                 
               
            }
          Console.WriteLine("next*********next");  

            Random val = new Random();
            
            for(int j = 1; j < 10; j++)
            {
                if(j%3==0 && j%5!=0)
                {
                   Console.WriteLine("Fizz");  
                }
                
                else if(j%5==0 && j%3!=0)
                {
                   Console.WriteLine("Buzz");  
                }
                else if(j%5==0 && j%3==0)
                {
                   Console.WriteLine("FizzBuzz");  
                }
            }

        }
    }
}
