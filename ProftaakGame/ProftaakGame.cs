using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Keys = Microsoft.Xna.Framework.Input.Keys;

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
            "X Y      X            X",
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

        public List<IGameObject> GameObjects
        {
            get { return Map.GameObjects; }
        }

        private Player Player
        {
            get { return Map.Player; }
        }

        public Map Map { get; private set; }

        /// <summary>
        ///     Allows the game to perform any initialization it needs to before starting to run.
        ///     This is where it can query for any required services and load any non-graphic
        ///     related content.  Calling base.Initialize will enumerate through any components
        ///     and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            base.Initialize();
            Connection = new SerialConnection("COM5");
        }

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
            // TODO: Unload any non ContentManager content here
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

            foreach (IGameObject gameObject in GameObjects)
            {
                gameObject.Update();
            }

            if (Player.IsDead)
            {
                Highscore.Add(new Highscore(Player));
                GameOver();
            }

            base.Update(gameTime);
        }

        private void GameOver()
        {
            MessageBox.Show("Game over nigga");
            Player.Lives = 3;
        }

        /// <summary>
        ///     This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.SkyBlue);

            spriteBatch.Begin();
            foreach (IGameObject gameObject in GameObjects)
            {
                gameObject.Draw(spriteBatch);
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}