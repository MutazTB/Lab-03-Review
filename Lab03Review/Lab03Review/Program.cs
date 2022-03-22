using System;
using System.IO;

namespace Lab03Review
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string path = "words.txt";

            Console.Write("Please enter 3 numbers : ");
            String input = Console.ReadLine();            
            Console.WriteLine(GetProduct(input));

            //Console.WriteLine("Challeng 2 \n" + average());
            //shape("Challeng 3 \n" + 9);
            //int[] arr = {1,1,2,2,3,3,3,1,1,5,5,6,7,8,2,1,1};
            //Console.WriteLine("Challeng 4 \n" + getPopularElement(arr));
            //Console.WriteLine("Challeng 5 \n" + max(arr));
            //String text = "This is a sentance about important things";            
            //WriteToFile("Challeng 6 \n" + path);
            //ReadFromFile("Challeng 7 \n" + path); 
            //DeleteWord("Challeng 8 \n" + path);                      
            //splitsentence("Challeng 9 \n" + text);
        }

        public static int GetProduct(String input) 
        {
            int product = 1;
            String[] numbers = input.Split(' ');
            if (numbers.Length < 3)
                return 0;
            else 
            for (int i = 0; i < 3; i++)
            {

                if (!int.TryParse(numbers[i], out int num))
                    product *= 1;
                else
                    product *= num;
            }

            return product;

        }

        public static int average() 
        {
            Console.Write("Please enter a number between 2-10:");
            int average = 0;
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                
                if (number < 2 || number > 10)
                {
                    Console.WriteLine("Please enter a number between 2-10");
                }
                else
                {
                    int sum = 0;
                    for (int i = 1; i <= number; i++)
                    {
                        Console.WriteLine($"{i} of {number} - Enter a number:");
                        String elementsFromUser = Console.ReadLine();
                        int num = Convert.ToInt32(elementsFromUser);
                        sum += num;
                    }
                    average = sum / number;
                    Console.Write($"The average of these {number} numbers is:");
                }                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return average;
        }

        public static void shape( int n ) 
        {            
            int space = n - 1;
            
            // till number of rows
            for (int i = 1; i <= n; i++)
            {
                // loop for initially space,
                // before star printing
                for (int j = 0; j < space; j++)
                    Console.Write(" ");

                // Print i+1 stars
                for (int j = 1; j <= i; j++)
                {
                    if (i % 2 == 0)
                        continue;
                    else
                    Console.Write("* ");
                }                
                Console.Write("\n");
                space--;
            }
            
            // reverse order
            space = 2;
            
            // till number of rows
            for (int i = n; i > 1; i--)
            {                
                // loop for initially space, before star printing
                for (int j = 1; j < space; j++)
                    Console.Write(" ");

                // Print i stars
                for (int j = 1; j < i; j++)
                {
                    if (i % 2 != 0)
                        continue;
                    else
                        Console.Write("* ");
                }

                Console.Write("\n");
                space++;
            }
        }

        public static int getPopularElement(int[] a)
        {
            int count = 1, tempCount;
            int popular = a[0];
            int temp = 0;
            for (int i = 0; i < (a.Length - 1); i++)
            {
                temp = a[i];
                tempCount = 0;
                for (int j = 1; j < a.Length; j++)
                {
                    if (temp == a[j])
                        tempCount++;
                }
                if (tempCount > count)
                {
                    popular = temp;
                    count = tempCount;
                }
            }
            return popular;
        }

        public static int max(int[] arr) 
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {                
                if (max < arr[i]) 
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static void WriteToFile(String filePath)
        {
            String content = Console.ReadLine();

            if (File.Exists(filePath))
            {
                StreamWriter sw = File.AppendText(filePath);
                sw.WriteLine(content);
            }
        }

        public static void ReadFromFile(String path)
        {
            String[] fileContent = File.ReadAllLines(path);
            for (int i = 0; i < fileContent.Length; i++)
                Console.WriteLine(fileContent[i]);
        }

        public static void DeleteWord(string path)
        {           
            string[] words = File.ReadAllLines(path);

            if (words.Length == 0)
            {
                Console.WriteLine("words.txt file is empty");                
            }
            Random rnd = new Random();
            int random = rnd.Next(words.Length);

            String word = "";

            StreamWriter sw = new StreamWriter(path);
            
                for (int i = 0; i < words.Length; i++)
                {
                    if (i == random)
                        word = words[i];
                    else
                        sw.WriteLine(words[i]);
                }            
            Console.WriteLine("\"{0}\" has been removed from words.txt file", word);                       
        }

        public static void splitsentence(String text) 
        {
            
            String[] txtarr = text.Split(' ');            
            for (int i = 0; i < txtarr.Length; i++)
            {
                Console.Write(txtarr[i] + ": " + txtarr[i].Length+" ");
            }           

        }
    }
}
