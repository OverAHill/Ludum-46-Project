using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Commons;

namespace KeepItAliveProject
{
    public partial class GameForm : Form
    {
        Creature creature;
        GameOverMenu gameOver;
        Player player;

        bool gameOverFlag = false;
        bool gameModeSwitch = false;
        
        public GameForm(StyleOfCreature style, string name, string pName)
        {
            InitializeComponent();

            this.graphicTimer.Tick += new System.EventHandler(this.Update);
            graphicTimer.Start();

            creature = new Creature(style);
            creature.SetStyle(style);
            creature.SetName(name);
            creatureNameBox.Text = creature.GetName();

            player = new Player(pName, 15);

            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            
            
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            creature.Draw(sender, e);
        }

        private void petButton_Click(object sender, EventArgs e)
        {
            creature.Pet();

            if (tutorialLabel.Visible)
            {
                tutorialLabel.Visible = false;
                tutorialLabel2.Visible = true;
            }
                
        }

        private void feedButton_Click(object sender, EventArgs e)
        {
            creature.Eat();

            if(gameModeSwitch)
            {
                player.ReduceNumberSacrifices(1);
            }

            if (tutorialLabel2.Visible)
            {
                tutorialLabel2.Visible = false;
                tutorialLabel3.Visible = true;
            }
        }

        private void tickleButton_Click(object sender, EventArgs e)
        {
            creature.Tickle();

            if (tutorialLabel3.Visible)
                tutorialLabel3.Visible = false;
            
        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            Draw(sender, e);
        }

        private void Update(object sender, EventArgs e)
        {
            creature.Update(sender, e);
            hapinessLabel.Text = "Happiness: " + creature.GetHappiness().ToString();
            hpLabel.Text = "HP: " + creature.GetHealth().ToString();
            hungerLabel.Text = "Hunger: " + creature.GetHunger().ToString();

            playerHealthLabel.Text = player.GetName() + "HP: " + player.GetHealth();
            sacrifcesLabel.Text = "Sacrifices: " + player.GetNumberSacrifices();

            this.Refresh();

            if (creature.GetHealth() == 0 && !gameOverFlag && !gameModeSwitch)
            {
                //game over
                gameOverFlag = true;
                gameOver = new GameOverMenu();
                gameOver.ShowDialog();
                this.Dispose(true);
                this.Close();
            }

            if(creature.playerAttackMode)
            {
                creature.playerAttackMode = false;
                player.ReduceHealth(2);
            }

            if(player.GetHealth() <= 5 && player.GetHealth() >= 2)
            {
                //you cant win
                youCantWinLabel.Visible = true;
            }

            if(player.GetHealth() < 2)
            {
                //Good bye message vis
                youCantWinLabel.Visible = false;
                goodbyeLabel.Visible = true;
                //remove youy cant win message
            }

            if(player.GetHealth() <= 0 && !gameOverFlag)
            {
                gameOverFlag = true;
                gameOver = new GameOverMenu();
                gameOver.ShowDialog();
                this.Dispose(true);
                this.Close();
            }

            if(creature.GetSentienceLevel() >= 1000)
            {
                gameModeSwitch = true;
                //disable creature update stats
                //creature now attacks you
                //no way to heal
                //limited number of sacrifices
                //sacrifices prevent attacks

                creature.gameModeFlag = true;

                playerHealthLabel.Visible = true;
                sacrifcesLabel.Visible = true;

                hapinessLabel.Visible = false; //disable them from reducing
                hpLabel.Visible = false; //atacks when hungry


            }
        }

        private void creatureNameBox_Click(object sender, EventArgs e)
        {

        }
    }
}
