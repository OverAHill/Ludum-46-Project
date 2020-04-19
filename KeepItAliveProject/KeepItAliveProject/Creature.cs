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
        Bitmap CurrentBackground;

        Bitmap IdleBitmap;

        Bitmap EatingBitmap;
        Bitmap TickeledBitmap;
        Bitmap PettingBitmap;
        Bitmap AttackBitmap;

        Bitmap HungryBitmap;
        Bitmap HappyBitmap;
        Bitmap LowHPBitmap;
        Bitmap SadBitmap;
        Bitmap AngryBitmap;
        Bitmap RefuseBitmap;

        Rectangle SourceRect;
        Rectangle DestRect;

        Rectangle BackgroundSourceRect;
        Rectangle BackgroundDestRect;

        Size BackgroundSize;
        Size CurrentSpriteSize;
        Size AdjustedSpriteSize;

        int NumberOfSprites;
        int CurrentSpriteNumber;

        Point Position;
        Point SpritePosition;
        Point BackgroundPosition;

        StyleOfCreature StyleOfCreature;
        AnimationState CurrentAnimationState;
        AnimationState PreviousAnimationState;

        string creatureName;

        uint healthPoint;

        int happinessLevel;
        int hungerLevel;

        double happinessIncrementer;
        double hungerIncrementer;
        double healthDecrementer;

        double sentienceLevel;
        double boredomLevel;


        int temporaryAnimationLoop;
        bool temporaryAnimationLoopActive = false;

        public bool gameModeFlag = false;
        public bool playerAttackMode = false;

        public double GetSentienceLevel() { return sentienceLevel; }

        int spriteScale = 3;

        public void SetStyle(StyleOfCreature style) { StyleOfCreature = style; }
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



        public Creature(StyleOfCreature style)
        {

            StyleOfCreature = style;

            switch (StyleOfCreature)
            {
                case StyleOfCreature.Goth:
                    IdleBitmap = new Bitmap(@"Images\Goth-Idle.PNG");
                    EatingBitmap = new Bitmap(@"Images\Goth-Eating.PNG");
                    TickeledBitmap = new Bitmap(@"Images\Goth-Tickle.PNG");
                    PettingBitmap = new Bitmap(@"Images\Goth-Pet.PNG");
                    RefuseBitmap = new Bitmap(@"Images\Goth-Refuse.PNG");

                    HungryBitmap = new Bitmap(@"Images\Goth-Hungry-Idle.PNG");
                    HappyBitmap = new Bitmap(@"Images\Goth-Happy-Idle.PNG");
                    LowHPBitmap = new Bitmap(@"Images\Goth-Low-HP.PNG");
                    SadBitmap = new Bitmap(@"Images\Goth-Sad-Idle.PNG");
                    AngryBitmap = new Bitmap(@"Images\Goth-Angry-Idle.PNG");

                    AttackBitmap = new Bitmap(@"Images\Goth-Attack.PNG");
                    break;

                case StyleOfCreature.Pastel:
                    IdleBitmap = new Bitmap(@"Images\Pastel-Idle.PNG");
                    EatingBitmap = new Bitmap(@"Images\Pastel-Eating.PNG");
                    TickeledBitmap = new Bitmap(@"Images\Pastel-Tickle.PNG");
                    PettingBitmap = new Bitmap(@"Images\Pastel-Pet.PNG");
                    RefuseBitmap = new Bitmap(@"Images\Pastel-Refuse.PNG");

                    HungryBitmap = new Bitmap(@"Images\Pastel-Hungry-Idle.PNG");
                    HappyBitmap = new Bitmap(@"Images\Pastel-Happy-Idle.PNG");
                    LowHPBitmap = new Bitmap(@"Images\Pastel-Low-HP.PNG");
                    SadBitmap = new Bitmap(@"Images\Pastel-Sad-Idle.PNG");
                    AngryBitmap = new Bitmap(@"Images\Pastel-Angry-Idle.PNG");
                    AttackBitmap = new Bitmap(@"Images\Pastel-Attack.PNG");
                    break;

                case StyleOfCreature.Strange:
                    IdleBitmap = new Bitmap(@"Images\Strange-Idle.PNG");
                    EatingBitmap = new Bitmap(@"Images\Strange-Eating.PNG");
                    TickeledBitmap = new Bitmap(@"Images\Strange-Tickle.PNG");
                    PettingBitmap = new Bitmap(@"Images\Strange-Pet.PNG");
                    RefuseBitmap = new Bitmap(@"Images\Strange-Refuse.PNG");

                    HungryBitmap = new Bitmap(@"Images\Strange-Hungry-Idle.PNG");
                    HappyBitmap = new Bitmap(@"Images\Strange-Happy-Idle.PNG");
                    LowHPBitmap = new Bitmap(@"Images\Strange-Low-HP.PNG");
                    SadBitmap = new Bitmap(@"Images\Strange-Sad-Idle.PNG");
                    AngryBitmap = new Bitmap(@"Images\Strange-Angry-Idle.PNG");
                    AttackBitmap = new Bitmap(@"Images\Strange-Attack.PNG");
                    break;

                default:
                    IdleBitmap = new Bitmap(@"Images\Goth-Idle.PNG");
                    EatingBitmap = new Bitmap(@"Images\Goth-Eating.PNG");
                    TickeledBitmap = new Bitmap(@"Images\Goth-Tickle.PNG");
                    PettingBitmap = new Bitmap(@"Images\Goth-Pet.PNG");
                    RefuseBitmap = new Bitmap(@"Images\Goth-Refuse.PNG");

                    HungryBitmap = new Bitmap(@"Images\Goth-Hungry-Idle.PNG");
                    HappyBitmap = new Bitmap(@"Images\Goth-Happy-Idle.PNG");
                    LowHPBitmap = new Bitmap(@"Images\Goth-Low-HP.PNG");
                    SadBitmap = new Bitmap(@"Images\Goth-Sad-Idle.PNG");
                    AngryBitmap = new Bitmap(@"Images\Goth-Angry-Idle.PNG");
                    AttackBitmap = new Bitmap(@"Images\Goth-Attack.PNG");
                    break;
            }            

            CurrentBackground = new Bitmap(@"Images\Background-Basic-Room.PNG");

            CurrentBitmap = IdleBitmap;
            CurrentSpriteSize = new Size(110, 93); //width height single sprite

            BackgroundPosition = new Point(0, 0);
            BackgroundSize = new Size(816, 489);

            BackgroundDestRect = new Rectangle(BackgroundPosition, BackgroundSize);
            BackgroundSourceRect = new Rectangle(BackgroundPosition, BackgroundSize);
            
            AdjustedSpriteSize = new Size(CurrentSpriteSize.Width * spriteScale, CurrentSpriteSize.Height * spriteScale);

            SpritePosition = new Point(0, 0);
            Position.X = 200;
            Position.Y = 150;
            CurrentSpriteNumber = 0;
            NumberOfSprites = 3;

            SourceRect = new Rectangle(SpritePosition, CurrentSpriteSize);
            DestRect = new Rectangle(Position, AdjustedSpriteSize);
            
            healthPoint = 5; //eventually health point will switch to 100 and they will be the players hp

            happinessLevel = 5;
            hungerLevel = 5;
            happinessIncrementer = 0;
            hungerIncrementer = 0;
            healthDecrementer = 0;

            sentienceLevel = 0;
            boredomLevel = 0;

            temporaryAnimationLoop = 0;
            temporaryAnimationLoopActive = false;


            CurrentAnimationState = AnimationState.Idle;
            PreviousAnimationState = AnimationState.Idle;
        }

        public void Draw(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(CurrentBackground, BackgroundDestRect, BackgroundSourceRect, GraphicsUnit.Pixel);
            e.Graphics.DrawImage(CurrentBitmap, DestRect, SourceRect, GraphicsUnit.Pixel);
        }

        public void Update(object sender, EventArgs e)
        {
            CurrentAnimationState = ProcessEvents();

            if (PreviousAnimationState != CurrentAnimationState && !temporaryAnimationLoopActive)
            {
                PreviousAnimationState = CurrentAnimationState;
                //update sprite pack
                switch (CurrentAnimationState)
                {
                    case AnimationState.Idle:
                        CurrentBitmap = IdleBitmap;
                        CurrentSpriteNumber = 0;
                        break;

                    case AnimationState.Happy:
                        CurrentBitmap = HappyBitmap;
                        CurrentSpriteNumber = 0;
                        break;

                    case AnimationState.Sad:
                        CurrentBitmap = SadBitmap;
                        CurrentSpriteNumber = 0;
                        break;

                    case AnimationState.Hungry:
                        CurrentBitmap = HungryBitmap;
                        CurrentSpriteNumber = 0;
                        break;

                    case AnimationState.LowHP:
                        CurrentBitmap = LowHPBitmap;
                        CurrentSpriteNumber = 0;
                        break;

                    case AnimationState.Angry:
                        CurrentBitmap = AngryBitmap;
                        CurrentSpriteNumber = 0;
                        break;

                    case AnimationState.Eating:
                        temporaryAnimationLoopActive = true;
                        CurrentBitmap = EatingBitmap;
                        CurrentSpriteNumber = 0;
                        break;

                    case AnimationState.Tickeled:
                        temporaryAnimationLoopActive = true;
                        CurrentBitmap = TickeledBitmap;
                        CurrentSpriteNumber = 0;
                        break;

                    case AnimationState.Pet:
                        temporaryAnimationLoopActive = true;
                        CurrentBitmap = PettingBitmap;
                        CurrentSpriteNumber = 0;
                        break;

                    case AnimationState.Refuse:
                        temporaryAnimationLoopActive = true;
                        CurrentBitmap = RefuseBitmap;
                        CurrentSpriteNumber = 0;
                        break;

                    case AnimationState.Attack:
                        temporaryAnimationLoopActive = true;
                        CurrentBitmap = AttackBitmap;
                        CurrentSpriteNumber = 0;
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

                    case AnimationState.Refuse:
                        temporaryAnimationLoop++;
                        break;

                    case AnimationState.Attack:
                        temporaryAnimationLoop++;
                        break;

                    default:
                        break;
                }

                if(temporaryAnimationLoop == 1 && CurrentAnimationState == AnimationState.Attack)
                {
                    if (CurrentAnimationState == AnimationState.Attack)
                        playerAttackMode = true;
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
        public void Tickle() //check if currently idle then check conditions and update stats
        {
            if(CurrentAnimationState != AnimationState.Tickeled && CurrentAnimationState != AnimationState.Eating 
                && CurrentAnimationState != AnimationState.Pet && CurrentAnimationState != AnimationState.Refuse && CurrentAnimationState != AnimationState.Attack)
            {
                if(hungerLevel > 7)
                {
                    CurrentAnimationState = AnimationState.Refuse;
                    happinessLevel--;
                    hungerLevel++;
                }
                else
                {
                    CurrentAnimationState = AnimationState.Tickeled;
                    happinessLevel++;
                    boredomLevel--;
                }               
            }          
        }

        public void Eat()
        {
            if (CurrentAnimationState != AnimationState.Tickeled && CurrentAnimationState != AnimationState.Eating
                && CurrentAnimationState != AnimationState.Pet && CurrentAnimationState != AnimationState.Refuse && CurrentAnimationState != AnimationState.Attack)
            {
                if (hungerLevel == 0)
                {
                    CurrentAnimationState = AnimationState.Refuse;
                    happinessLevel--;
                }
                else
                {
                    CurrentAnimationState = AnimationState.Eating;

                    if (hungerLevel >= 7)
                    {
                        hungerLevel -= 2;
                        happinessLevel++;
                        healthPoint++;
                    }
                    else
                    {
                        hungerLevel--;
                        healthPoint++;
                    }
                }
            } 
        }

        public void Pet()
        {
            if (CurrentAnimationState != AnimationState.Tickeled && CurrentAnimationState != AnimationState.Eating
               && CurrentAnimationState != AnimationState.Pet && CurrentAnimationState != AnimationState.Refuse && CurrentAnimationState != AnimationState.Attack)
            {
                if (hungerLevel >= 7)
                {
                    CurrentAnimationState = AnimationState.Refuse;
                    happinessLevel--;
                }
                else
                {
                    CurrentAnimationState = AnimationState.Pet;
                    happinessLevel++;
                    boredomLevel--;
                }
            }
        }

        public AnimationState ProcessEvents() //determin which idle state
        {
            AnimationState animationState = CurrentAnimationState;

            hungerIncrementer++;

            if (hungerIncrementer == 60)
            {
                hungerLevel++;
                hungerIncrementer = 0;
            }

            if (!gameModeFlag)
            {
                happinessIncrementer++;
                

                if (happinessIncrementer == 50)
                {
                    happinessLevel--;
                    happinessIncrementer = 0;
                }

                

                if (healthDecrementer == 20)
                {
                    healthPoint--;
                    healthDecrementer = 0;
                }

                //update variables (state machine)
                sentienceLevel++;

                if (sentienceLevel == 1000)
                {
                    //its time
                    Console.Write("scream");
                }

                if (sentienceLevel == 200)
                    SwitchBackground(2);

                if (sentienceLevel == 300)
                    SwitchBackground(3);

                if (sentienceLevel == 400)
                    SwitchBackground(4);

                if (sentienceLevel == 500)
                    SwitchBackground(5);

                if (sentienceLevel == 600)
                    SwitchBackground(6);

                if (sentienceLevel == 700)
                    SwitchBackground(7);

                if (sentienceLevel == 800)
                    SwitchBackground(8);

                if (sentienceLevel == 900)
                    SwitchBackground(9);

                if (sentienceLevel == 1000)
                    SwitchBackground(10);
            }



            if (CurrentAnimationState != AnimationState.Tickeled && CurrentAnimationState != AnimationState.Eating
               && CurrentAnimationState != AnimationState.Pet && CurrentAnimationState != AnimationState.Refuse && CurrentAnimationState != AnimationState.Attack)
            {
                animationState = AnimationState.Idle;

                if (hungerLevel > 7)
                {
                    if (hungerLevel >= 9)
                    {
                        animationState = AnimationState.Angry;
                        healthDecrementer++;

                        if(gameModeFlag)
                        {
                            animationState = AnimationState.Attack;
                            hungerLevel-= 2;
                        }
                    }
                    else
                    {
                        animationState = AnimationState.Hungry;
                    }
                }
                else if (hungerLevel > 4)
                {
                    healthDecrementer = 0;

                    if (happinessLevel < 5)
                    {
                        animationState = AnimationState.Sad;
                    }
                    else
                    {
                        animationState = AnimationState.Hungry;
                    }
                }
                else
                {
                    healthDecrementer = 0;

                    if (happinessLevel >= 5)
                    {
                        if (boredomLevel <= 5)
                        {
                            animationState = AnimationState.Happy;
                        }
                        else
                        {
                            animationState = AnimationState.Idle;
                        }
                    }
                    else
                    {
                        animationState = AnimationState.Sad;
                    }
                }

                if (healthPoint <= 1)
                {
                    animationState = AnimationState.LowHP;


                    if(healthPoint == 0)
                    {
                        //game over
                    }
                }
            }

            //caps 
            if (healthPoint > 10)
                healthPoint = 10;

            if (healthPoint < 0)
                healthPoint = 0;

            if (hungerLevel > 10)
                hungerLevel = 10;

            if (happinessLevel < 0)
                happinessLevel = 0;

            if (happinessLevel > 10)
                happinessLevel = 10;

            if (boredomLevel > 10)
                boredomLevel = 10;

            if (boredomLevel < 0)
                boredomLevel = 0;

            

            return animationState;   
        }

        public void SwitchBackground(int num)
        {
            switch(num)
            {
                case 1:
                    CurrentBackground = new Bitmap(@"Images\Background-Basic-Room.PNG");
                    break;

                case 2:
                    CurrentBackground = new Bitmap(@"Images\Background-Basic-Room-Vr2.PNG");
                    break;

                case 3:
                    CurrentBackground = new Bitmap(@"Images\Background-Basic-Room-Vr3.PNG");
                    break;

                case 4:
                    CurrentBackground = new Bitmap(@"Images\Background-Basic-Room-Vr4.PNG");
                    break;

                case 5:
                    CurrentBackground = new Bitmap(@"Images\Background-Basic-Room-Vr5.PNG");
                    break;

                case 6:
                    CurrentBackground = new Bitmap(@"Images\Background-Basic-Room-Vr6.PNG");
                    break;

                case 7:
                    CurrentBackground = new Bitmap(@"Images\Background-Basic-Room-Vr7.PNG");
                    break;

                case 8:
                    CurrentBackground = new Bitmap(@"Images\Background-Basic-Room-Vr8.PNG");
                    break;

                case 9:
                    CurrentBackground = new Bitmap(@"Images\Background-Basic-Room-Vr9.PNG");
                    break;

                case 10:
                    CurrentBackground = new Bitmap(@"Images\Background-Basic-Room-Vr10.PNG");
                    break;

                default:
                    break;
            }
        }
    }
}
