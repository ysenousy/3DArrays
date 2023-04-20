namespace _3DArrays
{
    internal class Program
    {

        static void AnotherExample() {
            
            int[,,] myArray = new int[3, 4, 2]; // declare a 3x4x2 array of integers

            // assign values to the array
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        myArray[i, j, k] = i + j + k;
                    }
                }
            }

            // print the values in the array
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine("Layer {0}:", i);
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        Console.Write("{0} ", myArray[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        } 
        static void Main(string[] args)
        {
           AnotherExample();
            //int[,,] myArray = { { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } },
            //        { { 9, 10 }, { 11, 12 }, { 13, 14 }, { 15, 16 } },
            //        { { 17, 18 }, { 19, 20 }, { 21, 22 }, { 23, 24 } } };

            //for (int i = 0; i < myArray.GetLength(0); i++)
            //{
            //    Console.WriteLine("Layer {0}:", i);
            //    for (int j = 0; j < myArray.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < myArray.GetLength(2); k++)
            //        {
            //            Console.Write("{0} ", myArray[i, j, k]);
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}