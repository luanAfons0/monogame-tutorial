using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace monogame_tutorial;

public class Sprite
{
    public Texture2D Texture;
    public Vector2 Position;
    
    public Sprite(Texture2D texture, Vector2 position)
    {
        this.Texture = texture;
        this.Position = position;
    }

    public virtual void Update()
    {
        
    }
}