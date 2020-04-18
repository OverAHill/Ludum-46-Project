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
        

        public GameForm(StyleOfCreature style, string name)
        {
            InitializeComponent();

            this.graphicTimer.Tick += new System.EventHandler(this.Update);
            graphicTimer.Start();

            creature = new Creature();
            creature.SetStyle(style);
            creature.SetName(name);
            creatureNameBox.Text = creature.GetName();

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
            creature.pet();

            if (tutorialLabel.Visible)
            {
                tutorialLabel.Visible = false;
                tutorialLabel2.Visible = true;
            }
                
        }

        private void feedButton_Click(object sender, EventArgs e)
        {
            creature.Eat();

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

            this.Refresh();
        }

        private void creatureNameBox_Click(object sender, EventArgs e)
        {

        }
    }
}
