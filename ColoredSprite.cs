using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace monogame_tutorial;

public class ColoredSprite: Sprite
{
    public Color Color;
    public ColoredSprite(Texture2D texture, Vector2 position, Color color) : base(texture, position)
    {
        this.Texture = texture;
        this.Position = position;
        this.Color = color;
    }
}