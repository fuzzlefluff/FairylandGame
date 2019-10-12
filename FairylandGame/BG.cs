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
    class BG
    {
        int xcord =0;
        int ycord =0;
        Texture2D bgTex;
        public BG(ContentManager content)
        {
            bgTex = content.Load<Texture2D>("BG");
        }
        public void Update(GameTime gameTime)
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(bgTex,new Rectangle(xcord,ycord,800,700),Color.White);
        }

    }
}
