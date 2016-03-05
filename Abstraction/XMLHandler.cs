using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction
{
    class XMLHandler : AbstractHandler 
    {
        public override void Open()
        {
            Console.WriteLine("Open file XML");
        }

        public override void Create()
        {
            Console.WriteLine("Create file XML");
        }

        public override void Change()
        {
            Console.WriteLine("Change file XML");
        }

        public override void Save()
        {
            Console.WriteLine("Save file XML\n");
        }
    }
}
