using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairylandGame
{


    class DeerHead
    {
        bool driftsP = false;
        bool driftsN = false;
        int driftAmount;
        int liftAmount;
        int xcord = 0;
        int ycord = 200;
        Texture2D monsterTex;
        int timeSinceLastFrame;
        int milisecondsPerFrame = 60;
        int maxFrames = 4;
        int currentFrame = 0;
        public bool isGone =false;

        public DeerHead(ContentManager content, Random rnd)
        {
            xcord = rnd.Next(300, 500);
            ycord = rnd.Next(500, 600);
            monsterTex = content.Load<Texture2D>("deermonsters");
        }

        public void Update(GameTime gameTime)
        {
            

            timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
            if (timeSinceLastFrame > milisecondsPerFrame)
            {
                if (currentFrame < maxFrames - 1) { currentFrame++; } else { currentFrame = 0; }

                timeSinceLastFrame -= milisecondsPerFrame;
            }
            ycord -= 2;
            if (ycord < -150) { isGone = true; }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(monsterTex,new Rectangle(xcord,ycord,100,100),new Rectangle(currentFrame * (monsterTex.Width/maxFrames),0,monsterTex.Width/maxFrames,monsterTex.Height),Color.White);
        }
    }
}
