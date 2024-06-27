using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace monogame_tutorial;

public class ScaledSprite: Sprite
{
    
    public Rectangle Rect => new Rectangle((int)Position.X,(int)Position.Y,50,100);
    
    public ScaledSprite(Texture2D texture, Vector2 position) : base(texture, position)
    {
        this.Texture = texture;
        this.Position = position;
    }
}