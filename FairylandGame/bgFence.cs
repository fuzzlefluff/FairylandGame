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
    class bgFence
    {
        int xcord = -10;
        int ycord = 340;
        Texture2D fenceChunk;

        public bgFence(ContentManager content)
        {
            fenceChunk = content.Load<Texture2D>("fence");
        }
        public void Update(GameTime gameTime)
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(fenceChunk,new Rectangle(xcord,ycord,100,100), Color.White);
            spriteBatch.Draw(fenceChunk, new Rectangle(xcord+100, ycord, 100, 100), Color.White);
            spriteBatch.Draw(fenceChunk, new Rectangle(xcord+200, ycord, 100, 100), Color.White);
            spriteBatch.Draw(fenceChunk, new Rectangle(xcord + 300, ycord, 100, 100), Color.White);
            spriteBatch.Draw(fenceChunk, new Rectangle(xcord + 400, ycord, 100, 100), Color.White);
            spriteBatch.Draw(fenceChunk, new Rectangle(xcord + 500, ycord, 100, 100), Color.White);
            spriteBatch.Draw(fenceChunk, new Rectangle(xcord + 600, ycord, 100, 100), Color.White);
            spriteBatch.Draw(fenceChunk, new Rectangle(xcord + 700, ycord, 100, 100), Color.White);
            spriteBatch.Draw(fenceChunk, new Rectangle(xcord + 800, ycord, 100, 100), Color.White);
        }
    }
}
