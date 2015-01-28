using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ProftaakGame.Objects;

namespace ProftaakGame
{
    internal class CoinBlock : Block
    {
        public CoinBlock(Map map, Texture2D texture, Vector2 position) : base(texture, position)
        {
            Map = map;
        }

        public Map Map { get; private set; }
    }
}