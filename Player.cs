using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace monogame_tutorial
{

    public class Player : Sprite
    {
        public readonly int PlayerSpeed = 3;

        public Rectangle Rect => new Rectangle(
            (int)Position.X,
            (int)Position.Y,
            Texture.Width,
            Texture.Height
        );

        public Player(Texture2D texture, Vector2 position, Color color) : base(texture, position, color) { }

        public override void Update(float newPlayerX, float newPlayerY)
        {
            this.Position.X = newPlayerX;
            this.Position.Y = newPlayerY;
        }
    }
}