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
    class conffetti
    {
        bool driftsP = false;
        bool driftsN = false;
        int driftAmount;
        int liftAmount;
        int xcord = 0;
        int ycord = 500;
        
        Texture2D confsquare;
        public bool isGone = false;
        Color bCollor;

        public conffetti(ContentManager content, Random rnd)
        {

            xcord = rnd.Next(0, 750);
            ycord = rnd.Next(500, 600);
            confsquare = content.Load<Texture2D>("confetti");

            int temp = rnd.Next(0, 3);
            if (temp == 0) { driftsP = true; }
            if (temp == 2) { driftsN = true; }
            driftAmount = rnd.Next(1, 14);
            liftAmount = rnd.Next(1, 55);
            temp = rnd.Next(0, 255);
            bCollor = new Color(rnd.Next(100, 255), rnd.Next(100, 255), rnd.Next(100, 255));
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
            
            spriteBatch.Draw(confsquare, new Rectangle(xcord, ycord, 10, 10), bCollor);
        }
    }
}
