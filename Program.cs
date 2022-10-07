namespace HelloWorld
{
    class Program
    {
        static void End()
        {
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
        
        static void Main(string[] args)
        {
            int[] numbers = {1,2,5,7,6 ,10, 8, 4, 9, 3};
            Console.WriteLine("Select a number between 1 and 10: ");
            int search = Convert.ToInt32(Console.ReadLine());
            int location = LinearSearch(numbers, search);
            
            int element =1;

            for (int i = 0; i< numbers.Length; i++)
            {
                if(numbers[i] == search)
                {
                    element = i;
                }
                
            }
            if (element >= 0)
            {
                Console.WriteLine("That number is located at element: " + element + " in the array");

            }
            static int LinearSearch(int[] numbers, int search)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == search)
                    {
                        return i;
                    }
                }
                return -1;
            }



            End();
        }
        
    }
}
