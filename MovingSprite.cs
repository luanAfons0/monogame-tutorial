using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace monogame_tutorial;

public class MovingSprite: Sprite
{
    public int Speed; 
    public MovingSprite(Texture2D texture, Vector2 position, int speed) : base(texture, position)
    {
        this.Position = position;
        this.Texture = texture;
        this.Speed = speed;
    }

    public override void Update()
    {
        Position.X += Speed;
    }
}