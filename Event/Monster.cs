using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class Monster
    {
        public MonsterInfo Info { get; private set; }
        public string Name { get; private set; }

        public void Init(string name, MonsterInfo info)
        {
            this.Info = info;
            this.Name = name;
        }

        public void TakeDamage(int damage)
        {
            //throw event
            var eventArgs = new GameEvent.MonsterEventArgs(this.Info);
            EventDispatcher.GetInstance().DispatchEvent("MONSTER_DIE", EventArgs.Empty);
        }
    }
}
