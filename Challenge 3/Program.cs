using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Challenge 3-1
             var likes = new List<string>();

             while (true)
             {
                 Console.WriteLine("Enter the names of your friend: ");
                 var input = Console.ReadLine();
                 if (String.IsNullOrWhiteSpace(input))
                 break;
                 likes.Add(input);
             }

             //Console.WriteLine(likes);

             if (likes.Count == 1)
             {
                 Console.WriteLine(likes[0] + " has liked your photo");
             }
             else if(likes.Count == 2)
             {
                 Console.WriteLine(likes[0] + " and " + likes[1] + " has liked your photo oooo");
             }
             else 
             {
                 Console.WriteLine(likes[0] + " " + likes[1] + " has liked your photo and many others");
             }


            // Challenge 3-2
              Console.WriteLine("Enter your name: ");
              var inputt = Console.ReadLine();

              var array = new char[inputt.Length];
              for (var i = inputt.Length; i > 0; i--)
                  array[inputt.Length - i] = inputt[i - 1];

              var reversed = new string(array);
              Console.WriteLine("Reversed name: " + reversed);


            // Challenge 3-3
            var brojevi = new List<long>();

            while ( brojevi.Count < 5 )
            {
                Console.WriteLine("Enter five numbers: ");
                var input2 = Convert.ToInt64(Console.ReadLine());
                
                if ( brojevi.Contains(input2))
                {
                    Console.WriteLine("Error");
                    brojevi.Clear();
                    continue;
                }
                brojevi.Add(input2);
            }

            brojevi.Sort();
            Console.WriteLine();
            foreach(var broj in brojevi)
            {
                Console.WriteLine(broj);
            }


            // Challenge 3-4
            Console.WriteLine("Enter the numbers: ");
            var upisi = Console.ReadLine();




        }    
    }
}
