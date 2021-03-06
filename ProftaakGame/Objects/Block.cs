﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ProftaakGame.Objects
{
    public class Block
    {
        public Block(Texture2D texture, Vector2 position, BlockType type)
        {
            Texture = texture;
            Position = position;
            Type = type;
        }

        public BlockType Type { get; private set; }
        public Vector2 Position { get; private set; }
        public Texture2D Texture { get; private set; }

        public virtual Rectangle Bounds
        {
            get { return new Rectangle((int) Position.X, (int) Position.Y, Texture.Width, Texture.Height); }
        }

        public void Update() {}

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Color.White);
        }
    }
}