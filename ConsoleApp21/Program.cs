namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] studentNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int no;
            for(int i = 0; i < studentNumbers.Length - 1; i++)
                for (int j = i + 1; j < studentNumbers.Length; j++)
                    if (studentNumbers[i] < studentNumbers[j]) 
                    { 
                        no = studentNumbers[i];
                        studentNumbers[i] = studentNumbers[j];
                        studentNumbers[j] = no;
                    
                    }
            foreach (int i in studentNumbers)   
            Console.WriteLine(i + "  ");
        }
    }
}