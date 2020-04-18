using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Commons;

namespace KeepItAliveProject
{
    class Creature
    {
        Bitmap CurrentBitmap;

        Rectangle SourceRect;
        Rectangle DestRect;

        Size CurrentSpriteSize;

        int NumberOfSprites;
        int CurrentSpriteNumber;

        Point Position;
        Point SpritePosition;

        StyleOfCreature Style;
        AnimationState CurrentAnimationState;

        string creatureName;
        uint healthPoint;
        int happinessLevel;
        int hungerLevel;

        public void SetStyle(StyleOfCreature style) { Style = style; }
        public void SetName(string name) { creatureName = name; }
        public string GetName() { return creatureName; }
        public void ReduceHealth(uint amount) { healthPoint -= amount; }
        public void IncreaseHealth(uint amount) { healthPoint += amount; }
        public uint GetHealth() { return healthPoint; }

        public void ReduceHappiness(int amount) { happinessLevel -= amount; }
        public void IncreaseHappiness(int amount) { happinessLevel += amount; }
        public int GetHappiness() { return happinessLevel; }

        public void ReduceHunger(int amount) { hungerLevel -= amount; }
        public void IncreaseHunger(int amount) { hungerLevel += amount; }
        public int GetHunger() { return hungerLevel; }



        public Creature()
        {
            CurrentBitmap = new Bitmap(@"Images\Ramona-Idle.PNG");
            CurrentSpriteSize = new Size(33, 66); //width height single sprite
            SpritePosition = new Point(0, 0);
            Position.X = 200;
            Position.Y = 300;
            CurrentSpriteNumber = 0;
            NumberOfSprites = 5;

            SourceRect = new Rectangle(SpritePosition, CurrentSpriteSize);
            DestRect = new Rectangle(Position, CurrentSpriteSize);

            healthPoint = 10;
            happinessLevel = 5;
            hungerLevel = 6;

            CurrentAnimationState = AnimationState.Idle;
        }

        public void Draw(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(CurrentBitmap, DestRect, SourceRect, GraphicsUnit.Pixel);
        }

        public void Update(object sender, EventArgs e)
        {
            //update variables (state machine)



            //update sprite pack
            switch(CurrentAnimationState)
            {
                case AnimationState.Idle:
                    break;

                case AnimationState.Happy:
                    break;

                case AnimationState.Hungry:
                    break;

                case AnimationState.LowHP:
                    break;

                default:
                    break;
            }

            //update sprite frame
            CurrentSpriteNumber++;

            if (CurrentSpriteNumber > NumberOfSprites)
                CurrentSpriteNumber = 0;

            //update sprite size

            //update bitmap
            SpritePosition.X = CurrentSpriteSize.Width * CurrentSpriteNumber;
            SourceRect.Size = CurrentSpriteSize;
            SourceRect.Location = SpritePosition;
            DestRect.Location = Position;
        }
    }
}
