using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGame.Extension
{
    public interface IHero
    {
        string Name { get; set; }
        int Health { get; set; }
        int Damage { get; set; }
        int Protect { get; set; }
        bool IsAlive { get;}
        void Atack(IHero person);
    } 

    public class Hero:IHero
    {
        public string Name { get; set; }
        public int Health { get; set; } = 100;
        public int Damage { get; set; } = 1;
        public int Protect { get; set; } = 0;
        public bool IsAlive => Health > 0;
        public List<InventoryItem> ListOnBody { get; set; } =new List<InventoryItem>();

        public void Atack(IHero enemy)
        {
            enemy.Health -= Damage;
        }
    }

    public class Enemy:IHero
    {
        public string Name { get; set; }
        public int Health { get; set; } = 100;
        public int Damage { get; set; } = 1;
        public int Protect { get; set; } = 0;
        public bool IsAlive => Health > 0;

        public void Atack(IHero hero)
        {
            hero.Health -= Damage;
        }
    }
}
