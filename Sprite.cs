using System.Data;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace monogame_tutorial;

public class Sprite
{
    public Texture2D Texture;
    public Vector2 Position;
    public Color Color;
    
    public Sprite(Texture2D texture, Vector2 position, Color color)
    {
        this.Texture = texture;
        this.Position = position;
        this.Color = color;
    }

    public virtual void Update(float newPlayerX,float newPlayerY) { }
}