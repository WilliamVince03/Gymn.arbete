using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Backgrounds_Player
{
    public class Player : Texture
    {
        public Vector2 Velocity;
        private bool hasJumped;

        public Player(Texture2D texture)
          : base(texture)
        {
        }

        public void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
                Velocity.X = 3f;
            else
                Velocity.X = 0f;

            if (Keyboard.GetState().IsKeyDown(Keys.Space) && hasJumped == false || Keyboard.GetState().IsKeyDown(Keys.Up) && hasJumped == false)
            {
                Position.Y -= 10f;
                Velocity.Y = -5f;
                hasJumped = true;
            }

            if (Position.Y >= 520) hasJumped = false;

            if (hasJumped) 
                Velocity.Y += 0.10f;
            else 
                Velocity.Y = 0f;            

            Position.Y += Velocity.Y;

        }
    }
}