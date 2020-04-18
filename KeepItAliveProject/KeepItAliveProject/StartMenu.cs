using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeepItAliveProject
{
    public partial class StartMenu : Form
    {
        GameForm game;
        public StartMenu()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            game = new GameForm();
            game.ShowDialog();
        }
    }
}
