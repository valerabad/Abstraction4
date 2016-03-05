using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction
{
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open file DOC");
        }

        public override void Create()
        {
            Console.WriteLine("Create file DOC");
        }

        public override void Change()
        {
            Console.WriteLine("Change file DOC");
        }

        public override void Save()
        {
            Console.WriteLine("Save file DOC\n");
        }
    }
}
