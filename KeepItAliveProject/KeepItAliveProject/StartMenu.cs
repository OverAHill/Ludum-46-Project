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
        string name;

        public StyleOfCreature selectedStyle;

        public StartMenu()
        {
            selectedStyle = StyleOfCreature.None;
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            name = nameTextBox.Text;

            if(!string.IsNullOrEmpty(name))
            {
                if (selectedStyle != StyleOfCreature.None)
                {
                    game = new GameForm(selectedStyle, name);
                    game.ShowDialog();

                    this.Close();
                }
                else
                {
                    warningLabel.Visible = true;
                }
            }
            else
            {
                enterNameWarningLabel.Visible = true;

                if (selectedStyle == StyleOfCreature.None)
                    warningLabel.Visible = true;
            }
            
        }

        private void gothColourButton_Click(object sender, EventArgs e)
        {
            selectedStyle = StyleOfCreature.Goth;
            highlightSelectedStyle(selectedStyle);
        }

        private void pastelColourButton_Click(object sender, EventArgs e)
        {
            selectedStyle = StyleOfCreature.Pastel;
            highlightSelectedStyle(selectedStyle);
        }

        private void referenceColourButton_Click(object sender, EventArgs e)
        {
            selectedStyle = StyleOfCreature.Reference;
            highlightSelectedStyle(selectedStyle);
        }

        private void highlightSelectedStyle(StyleOfCreature style)
        {
            switch (style)
            {
                case StyleOfCreature.Pastel:
                    pastelColourButton.BackColor = Color.AliceBlue;
                    gothColourButton.BackColor = Color.White;
                    referenceColourButton.BackColor = Color.White;
                    break;

                case StyleOfCreature.Goth:
                    gothColourButton.BackColor = Color.AliceBlue;
                    referenceColourButton.BackColor = Color.White;
                    pastelColourButton.BackColor = Color.White;
                    break;

                case StyleOfCreature.Reference:
                    referenceColourButton.BackColor = Color.AliceBlue;
                    gothColourButton.BackColor = Color.White;
                    pastelColourButton.BackColor = Color.White;
                    break;

                default:
                    break;

            }

        }

        private void StartMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
