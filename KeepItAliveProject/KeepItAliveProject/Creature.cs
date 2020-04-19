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

        Bitmap HungryBitmap;
        Bitmap HappyBitmap;
        Bitmap LowHPBitmap;
        Bitmap SadBitmap;
        Bitmap AngryBitmap;
        Bitmap RefuseBitmap;

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
        bool temporaryAnimationLoopActive = false;

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

            HungryBitmap = new Bitmap(@"Images\NovPixelIdle.PNG");
            HappyBitmap = new Bitmap(@"Images\NovPixelIdle.PNG");
            LowHPBitmap = new Bitmap(@"Images\NovPixelIdle.PNG");
            SadBitmap = new Bitmap(@"Images\NovPixelIdle.PNG");
            AngryBitmap = new Bitmap(@"Images\NovPixelIdle.PNG");
            RefuseBitmap = new Bitmap(@"Images\NovPixelIdle.PNG");

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
            temporaryAnimationLoopActive = false;


            CurrentAnimationState = AnimationState.Idle;
            PreviousAnimationState = AnimationState.Idle;
        }

        public void Draw(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(CurrentBitmap, DestRect, SourceRect, GraphicsUnit.Pixel);
        }

        public void Update(object sender, EventArgs e)
        {
            ProcessEvents();

            if(PreviousAnimationState != CurrentAnimationState && !temporaryAnimationLoopActive)
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
                        CurrentBitmap = HappyBitmap;
                        CurrentSpriteNumber = 0;
                        NumberOfSprites = 3;
                        CurrentSpriteSize.Width = 107;
                        CurrentSpriteSize.Height = 93;
                        break;

                    case AnimationState.Hungry:
                        CurrentBitmap = HappyBitmap;
                        CurrentSpriteNumber = 0;
                        NumberOfSprites = 3;
                        CurrentSpriteSize.Width = 107;
                        CurrentSpriteSize.Height = 93;
                        break;

                    case AnimationState.LowHP:
                        CurrentBitmap = LowHPBitmap;
                        CurrentSpriteNumber = 0;
                        NumberOfSprites = 3;
                        CurrentSpriteSize.Width = 107;
                        CurrentSpriteSize.Height = 93;
                        break;

                    case AnimationState.Eating:
                        temporaryAnimationLoopActive = true;
                        CurrentBitmap = EatingBitmap;
                        CurrentSpriteNumber = 0;
                        NumberOfSprites = 3;
                        CurrentSpriteSize.Width = 107;
                        CurrentSpriteSize.Height = 93;
                        break;

                    case AnimationState.Tickeled:
                        temporaryAnimationLoopActive = true;
                        CurrentBitmap = TickeledBitmap;
                        CurrentSpriteNumber = 0;
                        NumberOfSprites = 3;
                        CurrentSpriteSize.Width = 107;
                        CurrentSpriteSize.Height = 93;
                        break;

                    case AnimationState.Pet:
                        temporaryAnimationLoopActive = true;
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

                if (temporaryAnimationLoop == 4)
                {
                    CurrentAnimationState = AnimationState.Idle;
                    temporaryAnimationLoop = 0;
                    temporaryAnimationLoopActive = false;
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


        //put refuse in the following three functions
        public void Tickle()
        {
            CurrentAnimationState = AnimationState.Tickeled;
        }

        public void Eat()
        {
            CurrentAnimationState = AnimationState.Eating;
        }

        public void Pet()
        {
            CurrentAnimationState = AnimationState.Pet;
        }

        public void ProcessEvents()
        {
            //update variables (state machine)
            sentienceLevel += 0.1;

            if (sentienceLevel >= 100)
            {
                //its time
                Console.Write("scream");
            }

            if (temporaryAnimationLoopActive && temporaryAnimationLoop == 3)
            {
                //currentanimation state was successful e.g tickle, process this

                switch (CurrentAnimationState)
                {
                    case AnimationState.Eating:
                        //if hungry increase happiness
                        //if full decrease happinessand increase boredom
                        if (hungerLevel == 0)
                        {
                            happinessLevel--;
                        }
                        else
                        {
                            if (hungerLevel >= 7)
                            {
                                hungerLevel--;
                                happinessLevel++;
                            }
                            else
                            {
                                hungerLevel--;
                            }
                        }

                        break;

                    case AnimationState.Pet:
                        //if hungry hapiness decrease
                        //else increase hapiness 
                        if (hungerLevel >= 7)
                        {
                            happinessLevel--;
                        }
                        else
                        {
                            happinessLevel++;
                        }

                        break;

                    case AnimationState.Tickeled:
                        //if hungry hapiness decrease and increase hunger
                        //else increase hapiness and reduce boredom
                        if (hungerLevel >= 7)
                        {
                            happinessLevel--;
                            hungerLevel++;
                        }
                        else
                        {
                            happinessLevel++;
                            boredomLevel--;
                        }

                        break;

                    default:
                        break;
                }

            }
            /*
            else if (temporaryAnimationLoopActive == false) //when not in loop to do this is wrong
            {
                //boredom should passively increase
                //reduced by tickle and pet
                boredomLevel += 0.1;

                if (boredomLevel > 6)
                    sentienceLevel += 0.5;


                if (hungerLevel > 7)
                {
                    if (hungerLevel >= 9)
                    {
                       // CurrentAnimationState = AnimationState.Angry;
                        //loose health
                        //reduce happiness
                    }
                    else
                    {
                        //CurrentAnimationState = AnimationState.Hungry;
                    }
                }
                else if (hungerLevel > 4)
                {
                    if (happinessLevel < 5)
                    {
                        //CurrentAnimationState = AnimationState.Sad;
                    }
                    else
                    {
                        //CurrentAnimationState = AnimationState.Hungry;
                    }
                }
                else
                {
                    if (happinessLevel >= 5)
                    {
                        if (boredomLevel <= 5)
                        {
                            //CurrentAnimationState = AnimationState.Happy;
                            //slowly increase health
                        }
                        else
                        {
                           // CurrentAnimationState = AnimationState.Idle;
                        }
                    }
                    else
                    {
                        //CurrentAnimationState = AnimationState.Sad;
                    }
                }

                if (healthPoint <= 1)
                {
                    CurrentAnimationState = AnimationState.LowHP;
                }
            }*/

            

            //caps 

            if (healthPoint > 10)
                healthPoint = 10;

            if (hungerLevel > 10)
                hungerLevel = 10;

            if (happinessLevel < 0)
                happinessLevel = 0;

            if (happinessLevel > 10)
                happinessLevel = 10;

            if (boredomLevel < 0)
                boredomLevel = 0;

            if (boredomLevel > 10)
                boredomLevel = 10;
            


        }
    }
}
