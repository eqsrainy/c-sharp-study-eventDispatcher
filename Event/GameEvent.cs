using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class GameEvent
    {
        public class MonsterEventArgs : EventArgs
        {
            public MonsterInfo info;

            public MonsterEventArgs(MonsterInfo info)
            {
                this.info = info;
            }
        }
    }
}
