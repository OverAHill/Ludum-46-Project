using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepItAliveProject
{
    class Player
    {

        int Health;
        string pName;
        int numberOfSacrifices;

        public Player(string name, int sacrifices)
        {
            Health = 15;
            pName = name;
            numberOfSacrifices = sacrifices;
        }

        public int GetHealth() { return Health; }
        public void ReduceHealth(int amount) { Health -= amount; }
        public void IncreaseHealth(int amount) { Health += amount; }

        public void SetName(string name) { pName = name; }
        public string GetName() { return pName; }

        public int GetNumberSacrifices() { return numberOfSacrifices; }

        public void ReduceNumberSacrifices(int num) { numberOfSacrifices -= num; }

        public void Update(object sender, EventArgs e)
        {
            if(Health < 0)
            {
                //game over
            }
        }
    }
}
