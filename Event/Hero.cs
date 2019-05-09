using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class Hero
    {
        public string Name { get; private set; }

        public void Init(string name)
        {
            this.Name = name;
        }

        public void ActiveSkill()
        {
            Console.WriteLine("{0}의 공격!", this.Name);
        }
    }
}
