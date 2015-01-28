using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using ProftaakGame.Objects;

namespace ProftaakGame
{
    public class Map
    {
        private readonly ContentManager content;
        private readonly string[] data;

        public Map(ContentManager content, string[] data)
        {
            this.content = content;
            this.data = data;
            Parse();
        }

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
                    switch (str[x])
                    {
                        case 'X':
                            GameObjects.Add(new Block(content.Load<Texture2D>("block.png"), position));
                            break;

                        case 'Y':
                            if (Player == null)
                            {
                                Player = new Player(this, content.Load<Texture2D>("mariolopen.png"), position, 3);
                            }
                            else
                            {
                                Player.Position = position;
                            }
                            break;

                        case 'Z':
                            GameObjects.Add(new QuestionBlock(content.Load<Texture2D>("questionBlock.png"), position));
                            break;

                        case 'C':
                            GameObjects.Add(new CoinBlock(this, content.Load<Texture2D>("coinBlock.png"), position));
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