using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepItAliveProject
{
    class Creature
    {
        public Bitmap CurrentBitmap;
        public Rectangle SourceRect;
        public Rectangle DestRect;
        public Size CurrentSpriteSize;
        public int NumberOfSprites;
        public int CurrentSpriteNumber;
        public Point Position;
        protected Point SpritePosition;

        public Creature()
        {
            CurrentBitmap = new Bitmap(".../Images/Scott-Walk-Single.PNG");
            CurrentSpriteSize = new Size(37, 63); //wdith height single sprite
            SpritePosition = new Point(0, 0);
            Position.X = 200;
            Position.Y = 300;
            CurrentSpriteNumber = 0;
            NumberOfSprites = 1;
            SourceRect = new Rectangle(SpritePosition, CurrentSpriteSize);
            DestRect = new Rectangle(Position, CurrentSpriteSize);
        }

        protected void LoadBitmap(string fileLocation, ref Bitmap bitmap)
        {
            bitmap = new Bitmap(fileLocation);
        }

        protected void SetSize(Size size, int width, int height)
        {
            size = new Size(width, height);
        }



        //public void UpdateAnimation(AnimationState animationState)
        //{
        //    if (AnimationStateChange)
        //    {
        //        AnimationStateChange = false;
        //        switch (animationState)
        //        {
        //            case AnimationState.Idle:
        //                CurrentBitmap = IdleBitmap;
        //                CurrentSpriteSize = IdleSpriteSize;

        //                /* roation of the sprite
        //                if ((IdleSpriteFacingDirection == FacingDirection.Right) && (CurrentFacingDirection == FacingDirection.Left))
        //                {
        //                    CurrentBitmap.RotateFlip(RotateFlipType.Rotate180FlipY);
        //                    IdleSpriteFacingDirection = FacingDirection.Left;
        //                }
        //                else if ((IdleSpriteFacingDirection == FacingDirection.Left) && (CurrentFacingDirection == FacingDirection.Right))
        //                {
        //                    CurrentBitmap.RotateFlip(RotateFlipType.Rotate180FlipY);
        //                    IdleSpriteFacingDirection = FacingDirection.Right;
        //                }*/

        //                break;  
        //        }
        //       // UpdateSpriteNumber(animationState);
        //        CurrentSpriteNumber = 0;
        //    }

        //    /*if (animationState == AnimationState.Dying)
        //    {
        //        if (CurrentSpriteNumber == NumberOfSprites)
        //            CurrentSpriteNumber = NumberOfSprites - 1;
        //    }
        //    else
        //    {
        //        if (CurrentSpriteNumber == NumberOfSprites)
        //            CurrentSpriteNumber = 0;
        //    }*/

        //    UpdateRects();
        //    SourceRect.Size = CurrentSpriteSize;
        //    DestRect.Location = Position;
        //    SourceRect.X = CurrentSpriteSize.Width * CurrentSpriteNumber;

        //    //CheckHealth();
 
        //}

        //protected void UpdateRects()
        //{
        //    DestRect.Width = SourceRect.Width * 2;
        //    DestRect.Height = SourceRect.Height * 2;
        //}
    }
}
