using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Backgrounds_Player
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        public static int ScreenWidth = 1280;
        public static int ScreenHeight = 720;
        private Random dice = new Random();
        private int theme; // fast ta bort sen
        private BackgroundHandler backgroundHandler;
        private Player _player;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = ScreenWidth;
            _graphics.PreferredBackBufferHeight = ScreenHeight;
            _graphics.ApplyChanges();


            base.Initialize();

            //theme = dice.Next(0, 4);
            theme = 1;

            Setup();
            backgroundHandler = new BackgroundHandler(theme);        
        }
        void Setup()
        {
            TextureHandler.Instance.Theme = theme;
            _player = new Player(TextureHandler.Instance.GetBoyTexture())
            {
                Position = new Vector2(50, ScreenHeight - TextureHandler.Instance.GetBoyTexture().Height - 20),
                Layer = 1f,
            };

        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            TextureHandler.Instance.LoadTextures(this.Content);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            _player.Update(gameTime);
            backgroundHandler.Update(gameTime, _player.Velocity.X);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            
            backgroundHandler.Draw(_spriteBatch);
            _player.Draw(_spriteBatch);
            
            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
