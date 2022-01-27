﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroTest
{
    public class Enemy
    {
        public int HP { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }

        public void Attack(Hero enemy)
        {
            enemy.Defense(Atk);
        }
        public void Defense(int attack)
        {
            if (attack > Def) HP-=attack-Def;
        }
    }
}
