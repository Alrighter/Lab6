using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;
            string path;
            string filename;

            AbstractHandler file = new AbstractHandler();

            Console.Write("Lab6\nYou can:\n1) Open\n2) Create\n3) Edit\n\nEnter your answer:");
            answer = Convert.ToInt32(Console.ReadKey());
            Console.Write("Type the path of the file:");
            path = Console.ReadLine();
            Console.Write("Type filename including file extension:");
            filename = Console.ReadLine();

            file.constructor(filename,path);

            switch (answer)
            {
                case 1:
                    file.Open();
                    break;
                case 2:
                    file.Create();
                    break;
                case 3:
                    
                    break;
                default:
                    Console.WriteLine("Type the right answer");
                    break;
            }

        }
    }
}
