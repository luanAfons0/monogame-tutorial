using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogame_tutorial;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public Player Player;
    public Texture2D JoiaTexture;

    public bool isSpacePressed;
    public bool isLeftMouseButtonPressed;

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
        JoiaTexture = Content.Load<Texture2D>("joia");

        Player = new Player(JoiaTexture, new Vector2(10,10),Color.White);

        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        if (!isLeftMouseButtonPressed && Mouse.GetState().LeftButton == ButtonState.Pressed)
        {
            Console.WriteLine("Clicou com o botão esquerdo");
            Console.WriteLine("Posição x do click:" + Mouse.GetState().X);
            Console.WriteLine("Posição y do click:" + Mouse.GetState().Y);
            isLeftMouseButtonPressed = true;
        } ;
        
        if (Mouse.GetState().LeftButton == ButtonState.Released)
        {
            isLeftMouseButtonPressed = false;
        }
        
        if (!isSpacePressed && Keyboard.GetState().IsKeyDown(Keys.Space))
        {
            Console.WriteLine("Apertou espaço!");
            isSpacePressed = true;
        }

        if (Keyboard.GetState().IsKeyUp(Keys.Space))
        {
            isSpacePressed = false;
        }

        // TODO: Add your update logic here
        
        if (Keyboard.GetState().IsKeyDown(Keys.W))
        {
            Player.Update(Player.Position.X,Player.Position.Y-1);
        }
        
        if (Keyboard.GetState().IsKeyDown(Keys.A))
        {
            Player.Update(Player.Position.X-1,Player.Position.Y);
        }
        
        if (Keyboard.GetState().IsKeyDown(Keys.S))
        {
            Player.Update(Player.Position.X,Player.Position.Y+1);
        }
        
        if (Keyboard.GetState().IsKeyDown(Keys.D))
        {
            Player.Update(Player.Position.X+1,Player.Position.Y);
        }

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here

        _spriteBatch.Begin();
        _spriteBatch.Draw(Player.Texture, new Vector2(Player.Position.X, Player.Position.Y), Color.White);
        _spriteBatch.End();
        
        base.Draw(gameTime);
    }
}
