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

        public int GetHealth() { return Health; }
        public void ReduceHealth(int amount) { Health -= amount; }
        public void IncreaseHealth(int amount) { Health += amount; }

        public void Update(object sender, EventArgs e)
        {
            if(Health < 0)
            {
                //game over
            }
        }
    }
}
