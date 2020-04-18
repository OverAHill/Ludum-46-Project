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
        Size AdjustedSpriteSize;

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

        int spriteScale = 4;

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
            CurrentBitmap = new Bitmap(@"Images\NovPixelIdle.PNG");
            CurrentSpriteSize = new Size(107, 93); //width height single sprite

            
            AdjustedSpriteSize = new Size(CurrentSpriteSize.Width * spriteScale, CurrentSpriteSize.Height * spriteScale);

            SpritePosition = new Point(0, 0);
            Position.X = 150;
            Position.Y = 100;
            CurrentSpriteNumber = 0;
            NumberOfSprites = 3;

            SourceRect = new Rectangle(SpritePosition, CurrentSpriteSize);
            DestRect = new Rectangle(Position, AdjustedSpriteSize);
            
            healthPoint = 10; //eventually health point will switch to 100 and they will be the players hp
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

            if (hungerLevel <= 4)
            {
                //decay happiness
            }


            if (happinessLevel <= 3)
            {
                if (happinessLevel < 2)
                {
                    //angry
                }
                else
                {
                    //grumpy
                }
            }

            if (healthPoint < 0)
            {
                //dead
            }

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


            //update sprite position on sheet
            UpdateRects();

        }


        public void UpdateRects()
        {
            SpritePosition.X = CurrentSpriteSize.Width * CurrentSpriteNumber;
            SourceRect.Size = CurrentSpriteSize;
            SourceRect.Location = SpritePosition;

            AdjustedSpriteSize.Width = CurrentSpriteSize.Width * spriteScale;
            AdjustedSpriteSize.Height = CurrentSpriteSize.Height * spriteScale;

            DestRect.Location = Position;
            DestRect.Size = AdjustedSpriteSize;
        }
    }
}
