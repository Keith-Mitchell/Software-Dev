using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS478_text_adventure_game.Classes
{
     public class Enemy
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int Damage { get; set; }
    }
}
