using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("ФИО: ");
                SchoolboyFiller filler = new SchoolboyFiller();

                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine(filler.GetRandomFullName());
                }

                Console.WriteLine();

                SchoolboyStatus status = filler.GetRandomStatus();
                MarkGeneratorSettings settings = filler.GetRandomMarkSettings(status);

                MarkGenerator generator = new MarkGenerator();
                generator.SetMarkSettings(settings);

                Console.WriteLine($@"Оценки: 
5 - {settings.ProbabilityAn5Mark}%
4 - {settings.ProbabilityAn4Mark}%
3 - {settings.ProbabilityAn3Mark}%
2 - {settings.ProbabilityAn2Mark}%");
                Console.WriteLine();

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        int mark = generator.GetRandomMark();
                        switch (mark)
                        {
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write($"{mark,3}");
                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write($"{mark,3}");
                                break;
                            case 4:
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write($"{mark,3}");
                                break;
                            case 5:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write($"{mark,3}");
                                break;
                        }
                    }
                    Console.WriteLine();
                }

                Console.ReadKey();

            }
        }
    }
}
