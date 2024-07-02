using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogame_tutorial
{



    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D _joiaTexture;
        public Player Player1;
        public Player Player2;

        // kill player 2
        // public bool isPlayer2Dead;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _joiaTexture = Content.Load<Texture2D>("joia");

            Player1 = new Player(_joiaTexture, new Vector2(10, 10), Color.White);
            Player2 = new Player(_joiaTexture, new Vector2(500, 10), Color.Red);

        }

        protected override void Update(GameTime gameTime)
        {
            float changeY = 0;
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Player 1 logic
            // moving y
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                changeY -= 3;
                Player1.Update(Player1.Position.X, Player1.Position.Y - 3);
            }

            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                changeY += 3;
                Player1.Update(Player1.Position.X, Player1.Position.Y + 3);
            }

            // Stops player 1 to enter player 2 Y
            if (Player1.Rect.Intersects(Player2.Rect))
            {
                Player1.Update(Player1.Position.X, Player1.Position.Y -= changeY);
            }

            float changeX = 0;

            // moving x
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                changeX -= 3;
                Player1.Update(Player1.Position.X - 3, Player1.Position.Y);
            }

            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                changeX += 3;
                Player1.Update(Player1.Position.X + 3, Player1.Position.Y);
            }

            // Stops player 1 to enter player 2 X
            if (Player1.Rect.Intersects(Player2.Rect))
            {
                Player1.Update(Player1.Position.X -= changeX, Player1.Position.Y);
            }

            // Player 2 logic
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                Player2.Update(Player2.Position.X, Player2.Position.Y - 1);
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                Player2.Update(Player2.Position.X - 1, Player2.Position.Y);
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                Player2.Update(Player2.Position.X, Player2.Position.Y + 1);
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                Player2.Update(Player2.Position.X + 1, Player2.Position.Y);
            }

            // Collision logic
            // kill player 2
            // if (Player1.Rect.Intersects(Player2.Rect))
            // {
            //     isPlayer2Dead = true;
            // }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _spriteBatch.Draw(Player1.Texture, new Vector2(Player1.Position.X, Player1.Position.Y), Player1.Color);
            // kill player 2
            // if (!isPlayer2Dead)
            // {
            //     _spriteBatch.Draw(Player2.Texture, new Vector2(Player2.Position.X, Player2.Position.Y), Player2.Color);
            // }
            _spriteBatch.Draw(Player2.Texture, new Vector2(Player2.Position.X, Player2.Position.Y), Player2.Color);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}