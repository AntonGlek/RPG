using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Charecter
    {
        public int hp;
        public int mp;
        public int dmg;
        Charecter target;

        public void Attack()
        {
            target.hp -= dmg;
        }
    }
}
