using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Charecter
    {
        private int hp;

        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }

        private int mp;

        public int Mp
        {
            get { return mp; }
            set { mp = value; }
        }
        private int dmg;

        public int Dmg
        {
            get { return dmg; }
            set { dmg = value; }
        }
        Charecter target;

        public void Attack()
        {
            target.hp -= dmg;
        }
    }
}
