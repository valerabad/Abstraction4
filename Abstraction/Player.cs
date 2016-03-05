using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction
{
    class Player : IRecordable , IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Song is playing");
        }

        public void Record()
        {
            Console.WriteLine("Song is recording");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("Record pause");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Song pause");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("Record was stopped");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Song was stopped");
        }

    }
}
