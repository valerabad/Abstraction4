using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction
{
    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();

       static public void callsMethods(AbstractHandler file)
        {
            file.Create();
            file.Open();
            file.Change();
            file.Save();
        }
    }
}
