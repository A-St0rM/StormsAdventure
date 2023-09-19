using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormsAdventure.Fighting
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Attack_Value { get; set; }
        public int Enemy_Health { get; set; }

        public Enemy (string name, int attack_Value, int enemy_Health)
        {
            Name = name;
            Attack_Value = attack_Value;
            Enemy_Health = enemy_Health;

        }


    }
}
