using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open file TXT");
        }

        public override void Create()
        {
            Console.WriteLine("Create file TXT");
        }

        public override void Change()
        {
            Console.WriteLine("Change file TXT");
        }

        public override void Save()
        {
            Console.WriteLine("Save file TXT\n");
        }
    }
}
