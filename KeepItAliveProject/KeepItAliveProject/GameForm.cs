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
    public partial class GameForm : Form
    {
        public Bitmap CurrentBitmap;
        public Rectangle SourceRect;
        public Rectangle DestRect;
        public Size CurrentSpriteSize;
        public int NumberOfSprites;
        public int CurrentSpriteNumber;
        public Point Position;
        protected Point SpritePosition;

        public GameForm()
        {
            //Creature creature;
            //CurrentBitmap = new Bitmap("Scott-Walk-Single.PNG");
            //CurrentSpriteSize = new Size(37, 63); //wdith height single sprite
            //SpritePosition = new Point(0, 0);
            //Position.X = 200;
            //Position.Y = 300;
            //Graphics g = this.CreateGraphics();
            //g.DrawImage(CurrentBitmap, Position.X, Position.Y);
            InitializeComponent();

            //creature = new Creature();

            //this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            
            
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawImage(CurrentBitmap, Position.X, Position.Y);
        }

        private void petButton_Click(object sender, EventArgs e)
        {

        }

        private void feedButton_Click(object sender, EventArgs e)
        {

        }

        private void tickleButton_Click(object sender, EventArgs e)
        {

        }
    }
}
