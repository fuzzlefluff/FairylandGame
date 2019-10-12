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
    class Balloon
    {
        bool driftsP =false;
        bool driftsN =false;
        int driftAmount;
        int liftAmount;
        int xcord = 0;
        int ycord = 500;
        bool isBlue = false;
        bool isRed = false;
        bool isPurple = false;
        bool isYellow = false;
        bool isGreen = false;
        bool isPink = false;
        Texture2D BalloonColor;
        public bool isGone = false;
        Color bCollor;
        public Balloon(ContentManager content, Random rnd)
        {
            
            xcord = rnd.Next(0, 750);
            ycord = rnd.Next(500, 600);
            int temp = rnd.Next(1, 7);
            if (temp == 1) { isBlue = true; }
            if (temp == 2) { isRed = true; }
            if (temp == 3) { isPurple = true; }
            if (temp == 4) { isYellow = true; }
            if (temp == 5) { isGreen = true; }
            if (temp == 6) { isPink = true; }
            if (isBlue == true) { BalloonColor = content.Load<Texture2D>("BalloonBlue"); }
            if (isRed == true) { BalloonColor = content.Load<Texture2D>("BalloonRed"); }
            if (isPurple == true) { BalloonColor = content.Load<Texture2D>("BalloonPurple"); }
            if (isYellow == true) { BalloonColor = content.Load<Texture2D>("BalloonYellow"); }
            if (isGreen == true) { BalloonColor = content.Load<Texture2D>("BalloonGreen"); }
            if (isPink == true) { BalloonColor = content.Load<Texture2D>("BalloonPink"); }
            temp = rnd.Next(0, 3);
            if (temp == 0) { driftsP = true; }
            if (temp == 2) { driftsN = true; }
            driftAmount = rnd.Next(1, 6);
            liftAmount = rnd.Next(7, 9);
        }

        public void Update(GameTime gameTime)
        {
            
            ycord -= liftAmount;
            if (driftsP == true) { xcord += driftAmount; }
            if (driftsN == true) { xcord -= driftAmount; }
            if (ycord < -100) { isGone = true; }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Random rnd = new Random();
            spriteBatch.Draw(BalloonColor, new Rectangle(xcord, ycord, 50, 100), Color.White);
        }
    }
}
