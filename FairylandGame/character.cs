using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace FairylandGame
{
    class character
    {
        int xcord;
        int ycord;
        bool resetjump;
        bool isJumping;
        Texture2D characterBaseTexture;
        Texture2D characterMovingD;
        Texture2D characterMovingA;
        int jumpTime = 0;
        int milisecondsPerFrame = 50;
        int timeSinceLastFrame;
        int currentFrame = 0;
        int maxFrames = 8;

        public character(ContentManager content)
        {
            xcord = 100;
            ycord = 400;
            resetjump = false;
            isJumping = false;
            characterBaseTexture = content.Load<Texture2D>("character");
            characterMovingD = content.Load<Texture2D>("charactermovingD");
            characterMovingA = content.Load<Texture2D>("charactermovingA");
        }

        public void Update(GameTime gameTime)
        {
            timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
            if (timeSinceLastFrame > milisecondsPerFrame)
            {
                if (currentFrame < maxFrames - 1) { currentFrame++; } else { currentFrame = 0; }

                timeSinceLastFrame -= milisecondsPerFrame;
            }
                if (InputManager.isWpress == true && isJumping == false) { isJumping = true;  }
            if (isJumping == true)
            {
                if (jumpTime <= 20) { ycord -= 5; }
                else if (jumpTime >= 20) { ycord += 5; }
                if (jumpTime >= 41) { jumpTime = 0; isJumping = false; }
                else { jumpTime++; }
            }
            if (InputManager.isApress == true && xcord-3 >= 0) { xcord -= 3; }
            if (InputManager.isDpress == true && xcord+3 <= 750) { xcord += 3; }
        }
        public void Draw(SpriteBatch spriteBatch)
        {

            if (InputManager.isDpress == true) { spriteBatch.Draw(characterMovingD, new Rectangle(xcord, ycord, 50, 50), new Rectangle(currentFrame * (characterMovingD.Width/maxFrames), 0, characterMovingD.Width/maxFrames,characterMovingD.Height), Color.White); }
            else if (InputManager.isApress == true) { spriteBatch.Draw(characterMovingA, new Rectangle(xcord, ycord, 50, 50), new Rectangle(currentFrame * (characterMovingA.Width / maxFrames), 0, characterMovingA.Width / maxFrames, characterMovingA.Height), Color.White); }
            else { spriteBatch.Draw(characterBaseTexture, new Rectangle(xcord, ycord, 50, 50), Color.White); }
        }
    }
}
