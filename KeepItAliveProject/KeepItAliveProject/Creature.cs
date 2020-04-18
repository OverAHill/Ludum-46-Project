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
        Bitmap IdleBitmap;
        Bitmap EatingBitmap;
        Bitmap TickeledBitmap;
        Bitmap PettingBitmap;


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
        AnimationState PreviousAnimationState;

        string creatureName;
        uint healthPoint;
        int happinessLevel;
        int hungerLevel;
        double sentienceLevel;
        double boredomLevel;
        int temporaryAnimationLoop;

        public double GetSentienceLevel() { return sentienceLevel; }

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
            IdleBitmap = new Bitmap(@"Images\NovPixelIdle.PNG");
            EatingBitmap = new Bitmap(@"Images\Eating.PNG");
            TickeledBitmap = new Bitmap(@"Images\Tickeled.PNG");
            PettingBitmap = new Bitmap(@"Images\Pet.PNG");

            CurrentBitmap = IdleBitmap;
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
            sentienceLevel = 0;
            boredomLevel = 0;
            temporaryAnimationLoop = 0;

            CurrentAnimationState = AnimationState.Idle;
            PreviousAnimationState = AnimationState.Idle;
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
                CurrentAnimationState = AnimationState.Idle;
            }


            if (happinessLevel <= 3)
            {
                if (happinessLevel < 2)
                {
                    //angry
                    CurrentAnimationState = AnimationState.Idle;
                }
                else
                {
                    //grumpy
                    CurrentAnimationState = AnimationState.Idle;
                }
            }

            if (healthPoint < 0)
            {
                //dead
                CurrentAnimationState = AnimationState.Idle;
            }

            sentienceLevel += 0.1;

            if(sentienceLevel >= 100)
            {
                //its time
                Console.Write("scream");
            }

            if(PreviousAnimationState != CurrentAnimationState)
            {
                PreviousAnimationState = CurrentAnimationState;
                //update sprite pack
                switch (CurrentAnimationState)
                {
                    case AnimationState.Idle:
                        CurrentBitmap = IdleBitmap;
                        CurrentSpriteNumber = 0;
                        NumberOfSprites = 3;
                        CurrentSpriteSize.Width = 107;
                        CurrentSpriteSize.Height = 93;
                        break;

                    case AnimationState.Happy:
                        CurrentSpriteNumber = 0;
                        NumberOfSprites = 3;
                        CurrentSpriteSize.Width = 107;
                        CurrentSpriteSize.Height = 93;
                        break;

                    case AnimationState.Hungry:
                        CurrentSpriteNumber = 0;
                        NumberOfSprites = 3;
                        CurrentSpriteSize.Width = 107;
                        CurrentSpriteSize.Height = 93;
                        break;

                    case AnimationState.LowHP:
                        CurrentSpriteNumber = 0;
                        NumberOfSprites = 3;
                        CurrentSpriteSize.Width = 107;
                        CurrentSpriteSize.Height = 93;
                        break;

                    case AnimationState.Eating:
                        CurrentBitmap = EatingBitmap;
                        CurrentSpriteNumber = 0;
                        NumberOfSprites = 3;
                        CurrentSpriteSize.Width = 107;
                        CurrentSpriteSize.Height = 93;
                        break;

                    case AnimationState.Tickeled:
                        CurrentBitmap = TickeledBitmap;
                        CurrentSpriteNumber = 0;
                        NumberOfSprites = 3;
                        CurrentSpriteSize.Width = 107;
                        CurrentSpriteSize.Height = 93;
                        break;

                    case AnimationState.Pet:
                        CurrentBitmap = PettingBitmap;
                        CurrentSpriteNumber = 0;
                        NumberOfSprites = 3;
                        CurrentSpriteSize.Width = 107;
                        CurrentSpriteSize.Height = 93;
                        break;

                    default:
                        break;
                }

                

            }

            //update sprite frame
            CurrentSpriteNumber++;

            if (CurrentSpriteNumber > NumberOfSprites)
            {
                switch (CurrentAnimationState)
                {
                    case AnimationState.Eating:
                        temporaryAnimationLoop++;
                        break;

                    case AnimationState.Tickeled:
                        temporaryAnimationLoop++;
                        break;

                    case AnimationState.Pet:
                        temporaryAnimationLoop++;
                        break;

                    default:
                        break;
                }


                if (temporaryAnimationLoop > 4)
                {
                    CurrentAnimationState = AnimationState.Idle;
                    temporaryAnimationLoop = 0;
                }

                CurrentSpriteNumber = 0;
            }
               

            

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


        public void Tickle()
        {
            CurrentAnimationState = AnimationState.Tickeled;
        }

        public void Eat()
        {
            CurrentAnimationState = AnimationState.Eating;
        }

        public void pet()
        {
            CurrentAnimationState = AnimationState.Pet;
        }
    }
}
