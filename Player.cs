using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace monogame_tutorial;

public class Player: Sprite
{
    public readonly int PlayerSpeed = 1;
    
    public Player(Texture2D texture, Vector2 position, Color color) : base(texture,position,color)
    {
        
    }

    public override void Update(float newPlayerX,float newPlayerY)
    {
        this.Position.X = newPlayerX;
        this.Position.Y = newPlayerY;
    }
}