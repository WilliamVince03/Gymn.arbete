using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Backgrounds_Player
{
    public class ObstacleHandler
    {
        public List<Obstacles> obstacles = new List<Obstacles>();
        public ObstacleHandler(int theme, int positionx)
        {

            switch (theme)
            {
                case 1:
                    //City
                    var newspaper = new Obstacles(TextureHandler.Instance.GetTexture(TextureType.Obstacle), TextureHandler.Instance.GetTextureAnimationFrames(TextureType.Obstacle), positionx, true);
                    obstacles.Add(newspaper);
                    break;
                //case 2:
                //    //ice
                //    break;
                //case 3:
                //    // Savannah
                //    break;
                //case 4:
                //    //djungle
                //    break;
                default:
                    var obstacle = new Obstacles(TextureHandler.Instance.GetTexture(TextureType.Obstacle), TextureHandler.Instance.GetTextureAnimationFrames(TextureType.Obstacle), positionx);
                    obstacles.Add(obstacle);

                    break;
            }

        }
        internal void Update(GameTime gameTime, float playerVelocityX, Vector2 cameraPosition) 
        {

            foreach (var obstacle in obstacles) obstacle.Update(gameTime, playerVelocityX);

            obstacles.RemoveAll(o=>o.Position.X < cameraPosition.X - 200);

        }
        internal void Draw(SpriteBatch spriteBatch, Vector2 cameraPosition)
        {
            foreach (var obstacle in obstacles) obstacle.Draw(spriteBatch, cameraPosition);   
        }


    }
}