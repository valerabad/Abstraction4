using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction
{
    interface IPlayable
    {
        void Play();        
        void Pause();
        void Stop();
    }
}
