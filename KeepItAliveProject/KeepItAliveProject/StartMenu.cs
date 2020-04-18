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
    

    public partial class StartMenu : Form
    {
        GameForm game;
        public StyleOfCreature selectedStyle;

        public StartMenu()
        {
            selectedStyle = StyleOfCreature.None;
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if(selectedStyle != StyleOfCreature.None)
            {
                game = new GameForm(selectedStyle);
                game.ShowDialog();
            }
        }

        private void gothColourButton_Click(object sender, EventArgs e)
        {
            selectedStyle = StyleOfCreature.Goth;
        }

        private void pastelColourButton_Click(object sender, EventArgs e)
        {
            selectedStyle = StyleOfCreature.Pastel;
        }

        private void referenceColourButton_Click(object sender, EventArgs e)
        {
            selectedStyle = StyleOfCreature.Reference;
        }
    }
}
