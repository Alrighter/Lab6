using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {

            AbstractHandler file = new AbstractHandler();

            Console.Write("Lab6\nYou can:\n1) Open\n2) Create\n3) Edit\n\nEnter your answer:");
            int answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the path of the file: ");
            string path = Console.ReadLine();
            Console.WriteLine("Type filename including file extension: ");
            string filename = Console.ReadLine();

            file.constructor(path,filename);
            
            switch (answer)
            {
                case 1:
                    file.Open();
                    break;
                case 2:
                    file.Create();
                    break;
                case 3:
                    Console.Write("Do you want to \n1) Move\n2) Delete\n file? : ");
                    int editAnswer = Convert.ToInt32(Console.ReadKey());
                    if (editAnswer == 1)
                    {
                        Console.Write("Type file destination:");
                        string path2 = Console.ReadLine();
                        file.constructor(filename, path, path2);
                        file.Move();
                    }
                    else if (editAnswer == 2)
                    {
                        file.Delete();
                    }
                    else
                    {
                        Console.WriteLine("Type the correct answer!");
                    }
                    break;
                default:
                    Console.WriteLine("Type the correct answer");
                    break;
            }

            Console.ReadLine();

        }
    }
}
