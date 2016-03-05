using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction
{
    enum typeFile: byte { XML, DOC, TXT };
    class Program
    {
        static void Main(string[] args)
        {
            int task;
            while (true)
            {
                Console.WriteLine("Enter 1 or 2 for change task: ");
                int.TryParse(Console.ReadLine(), out task);
                switch (task)
                {
                    case 1:
                        typeFile typeFILE;
                        for (typeFILE = typeFile.XML; typeFILE <= typeFile.TXT; typeFILE++)
                        {
                            switch (typeFILE)
                            {
                                case typeFile.XML:
                                    AbstractHandler.callsMethods(new XMLHandler());
                                    break;
                                case typeFile.DOC:
                                    AbstractHandler.callsMethods(new DOCHandler());
                                    break;
                                case typeFile.TXT:
                                    AbstractHandler file = new TXTHandler();  // не знаю каким лучше способом вызывать методы
                                    file.Create();
                                    file.Open();
                                    file.Change();
                                    file.Save();
                                    break;
                            }
                        }
                        break;
                    case 2:
                        Player player = new Player();
                        IRecordable IRec = (IRecordable)player;
                        IPlayable IPlay = (IPlayable)player;

                        player.Play();
                        IPlay.Pause();
                        IPlay.Stop();

                        Console.WriteLine();

                        player.Record();
                        IRec.Pause();
                        IRec.Stop();

                        break;
                    default:
                        Environment.Exit(0  );
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}
