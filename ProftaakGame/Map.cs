using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ProftaakGame.Objects;

namespace ProftaakGame
{
    public class Map
    {
        private readonly string[] data;

        public Map(ProftaakGame game, string[] data)
        {
            Game = game;
            this.data = data;
            Parse();
        }

        public ProftaakGame Game { get; private set; }
        public List<Block> GameObjects { get; private set; }
        public Player Player { get; private set; }
        public int Heigth { get; private set; }

        private void Parse()
        {
            Heigth = data.Length*16;

            GameObjects = new List<Block>();

            const int size = 16;
            for (int y = 0; y < data.Length; y++)
            {
                string str = data[y];
                for (int x = 0; x < str.Length; x++)
                {
                    var position = new Vector2(x*size, y*size);
                    switch (char.ToUpper(str[x]))
                    {
                        case 'X':
                            GameObjects.Add(new Block(Game.Content.Load<Texture2D>("block.png"), position,
                                BlockType.Regular));
                            break;

                        case 'Y':
                            if (Player == null)
                            {
                                Player = new Player(this, Game.Content.Load<Texture2D>("mario.png"), position, 3);
                            }
                            else
                            {
                                Player.Position = position;
                            }
                            break;

                        case 'C':
                            GameObjects.Add(new Block(Game.Content.Load<Texture2D>("coin.png"), position, BlockType.Coin));
                            break;

                        case 'F':
                            GameObjects.Add(new Block(Game.Content.Load<Texture2D>("flag.png"), position, BlockType.Flag));
                            break;

                        case 'M':
                            GameObjects.Add(new Block(Game.Content.Load<Texture2D>("enemy.png"), position, BlockType.Enemy));
                            break;
                    }
                }
            }
        }

        public void Reset()
        {
            Parse();
        }
    }
}