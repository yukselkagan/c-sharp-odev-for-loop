using System;

namespace c_sharp_odev_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int number1 = int.Parse(Console.ReadLine());
            for(int i=1; i < number1; i++)
            {
                if((i % 2) == 1)
                {
                    Console.WriteLine(i);
                }
            }


            int totalOdd = 0;
            int totalEven = 0;

            for(int i=0; i <= 1000; i++){

                if( (i % 2) == 1 ){
                    totalOdd += i;                    
                }else{
                    totalEven += i;
                }
            }
            Console.WriteLine("Total odd number: " + totalOdd);
            Console.WriteLine("Total even number: " + totalEven);

            for(int i=1; i < 10; i++){
                if(i == 4){
                    break;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("----------");

            for(int i=1; i < 10; i++){
                if(i == 4){
                    continue;
                }
                Console.WriteLine(i);
            }



        }
    }
}
