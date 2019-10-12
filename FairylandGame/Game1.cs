using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace FairylandGame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        character player;
        InputManager inputs;
        Random random;
        int MilisecondsperTick = 505;
        int timesincelastTick = 0;
        bool changeBGcolor;
        Color BGcolor = Color.CornflowerBlue;
        List<Balloon> balloons = new List<Balloon>();
        List<conffetti> conffettis = new List<conffetti>();
        bool partyTime = true;
        bgFence bgFence;
        BG bgimage;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {

            inputs = new InputManager();
            base.Initialize();
            random = new Random();
            changeBGcolor = true;
            
            
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            player = new character(Content);
            bgFence = new bgFence(Content);
            bgimage = new BG(Content);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            timesincelastTick += gameTime.ElapsedGameTime.Milliseconds;

            if (timesincelastTick > MilisecondsperTick && partyTime == true) { changeBGcolor = true; timesincelastTick -= MilisecondsperTick;
                for (int i = 0; i < 3; i++)
                {
                    balloons.Add(new Balloon(Content, random));
                }
               
                for (int i = 0; i < 900; i++)
                {
                    conffettis.Add(new conffetti(Content, random));
                }
                  
            }
            if (timesincelastTick > MilisecondsperTick && partyTime == false) { changeBGcolor = false; timesincelastTick -= MilisecondsperTick;

            }

            inputs.Update();
            // TODO: Add your update logic here
            player.Update(gameTime);
            

            for (int i = 0; i < balloons.Count; i++)
            {
                balloons[i].Update(gameTime);
                if (balloons[i].isGone == true) { balloons.RemoveAt(i); }
            }
            for (int i = 0; i < conffettis.Count; i++)
            {
                conffettis[i].Update(gameTime);
                if (conffettis[i].isGone == true) { conffettis.RemoveAt(i); }
            }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            if (partyTime == false) { BGcolor = Color.DarkSlateGray; }
            else if (changeBGcolor == true) { BGcolor = new Color(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)); changeBGcolor = false;  }
            
            GraphicsDevice.Clear(BGcolor);

            spriteBatch.Begin(SpriteSortMode.Immediate,BlendState.AlphaBlend,SamplerState.PointClamp,null,null,null);
            bgimage.Draw(spriteBatch);
            bgFence.Draw(spriteBatch);
            for (int i = 0; i < conffettis.Count; i++)
            {
                conffettis[i].Draw(spriteBatch);
            }
            for (int i = 0; i < balloons.Count; i++)
            {
                balloons[i].Draw(spriteBatch);
            }
            player.Draw(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
