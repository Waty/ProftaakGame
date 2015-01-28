using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ProftaakGame.Objects;

namespace ProftaakGame
{
    /// <summary>
    ///     This is the main type for your game
    /// </summary>
    public class ProftaakGame : Game
    {
        private readonly string[] mapData =
        {
            "XXXXXXXXXX",
            "X        X",
            "X        X",
            "X        X",
            "X Y      X      C      X",
            "X                    XXX",
            "X                   XXXXX",
            "X                  XXXXXXX",
            "X                 XXXXXXXXX      Z",
            "XXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        };

        public SerialConnection Connection;
        // ReSharper disable once NotAccessedField.Local
        private readonly GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        public ProftaakGame()
        {
            graphics = new GraphicsDeviceManager(this);

            Content.RootDirectory = "Content";
            Window.AllowUserResizing = true;
        }

        public List<Block> Blocks
        {
            get { return Map.GameObjects; }
        }

        private Player Player
        {
            get { return Map.Player; }
        }

        public Map Map { get; private set; }

        /// <summary>
        ///     LoadContent will be called once per game and is the place to load
        ///     all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Map = new Map(Content, mapData);
        }

        /// <summary>
        ///     UnloadContent will be called once per game and is the place to unload
        ///     all content.
        /// </summary>
        protected override void UnloadContent()
        {
            Connection.Dispose();
        }

        /// <summary>
        ///     Allows the game to run logic such as updating the world,
        ///     checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }

            SerialConnection.SerialData data = Connection.ReadAvailableData();
            if (data != null)
            {
                Debug.WriteLine(data.ToString());
            }

            foreach (Block block in Blocks)
            {
                block.Update();
            }
            Player.Update();

            if (Player.IsDead)
            {
                Highscore.Add(new Highscore(Player.Coins, Player.Lives));
                GameOver();
            }

            base.Update(gameTime);
        }

        private void GameOver()
        {
            Connection.WriteData(SerialConnection.MessageType.win_Game, new Object[] {0});
            Exit();
        }

        /// <summary>
        ///     This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.SkyBlue);

            spriteBatch.Begin();
            foreach (Block block in Blocks)
            {
                block.Draw(spriteBatch);
            }
            Player.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}