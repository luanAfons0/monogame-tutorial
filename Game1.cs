using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogame_tutorial;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private Texture2D _texture;

    private List<MovingSprite> _movingSprites;
    
    // private Sprite _joiaSprite;
    // private ScaledSprite _superJoiaScaledSprite;
    // private ColoredSprite _joiaColoredSprite;
    // private MovingSprite _movingJoia;
    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        _texture = Content.Load<Texture2D>("joia");
        
        // _movingJoia = new MovingSprite(_texture,new Vector2(0,10), 5);
        // _joiaSprite = new Sprite(_texture, new Vector2(120,10));
        // _superJoiaScaledSprite = new ScaledSprite(_texture, new Vector2(240, 10));
        // _joiaColoredSprite = new ColoredSprite(_texture, new Vector2(360, 10), Color.Coral);

        _movingSprites = new List<MovingSprite>();
        
        for (int a = 0; a < 10 ; a+=2)
        {
            _movingSprites.Add((new MovingSprite(_texture, new Vector2(10,10),a)));
        }
        
        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        foreach (var sprite in _movingSprites)
        {
            sprite.Update();
        }
        
        // TODO: Add your update logic here

        // _movingJoia.Update();
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here

        _spriteBatch.Begin(samplerState: SamplerState.PointClamp);
        foreach (var sprite in _movingSprites)
        {
            _spriteBatch.Draw(sprite.Texture,sprite.Position,Color.White);
        }
        // _spriteBatch.Draw(_joiaSprite.Texture, _joiaSprite.Position, Color.White);
        // _spriteBatch.Draw(_superJoiaScaledSprite.Texture, _superJoiaScaledSprite.Position, Color.White);
        // _spriteBatch.Draw(_joiaColoredSprite.Texture, _joiaColoredSprite.Position, _joiaColoredSprite.Color);
        // _spriteBatch.Draw(_movingJoia.Texture, _movingJoia.Position, Color.White);
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
