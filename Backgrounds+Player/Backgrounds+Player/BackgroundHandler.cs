using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Backgrounds_Player
{
    public class BackgroundHandler
    {
        public List<ScrollingBackgroundLayer> backgrounds = new List<ScrollingBackgroundLayer>();

        public BackgroundHandler(int theme)
        {
            switch (theme)
            {
                case 1:
                    var foreground = new ScrollingBackgroundLayer(TextureHandler.Instance.Foreground, 61f, 0.99f);
                    backgrounds.Add(foreground);

                    var houses = new ScrollingBackgroundLayer(TextureHandler.Instance.Houses, 60f, 0.9f);
                    backgrounds.Add(houses);

                    var backhouses1 = new ScrollingBackgroundLayer(TextureHandler.Instance.Backhouses1, 40f, .8f);
                    backgrounds.Add(backhouses1);

                    var clouds2 = new ScrollingBackgroundLayer(TextureHandler.Instance.Clouds2, 30f, .79f, true);
                    backgrounds.Add(clouds2);

                    var backhouses2 = new ScrollingBackgroundLayer(TextureHandler.Instance.Backhouses2, 25f, .78f);
                    backgrounds.Add(backhouses2);

                    var clouds1 = new ScrollingBackgroundLayer(TextureHandler.Instance.Clouds1, 10f, .7f, true, false);
                    backgrounds.Add(clouds1);

                    var skybox = new ScrollingBackgroundLayer(TextureHandler.Instance.Skybox, 0f, .1f);
                    backgrounds.Add(skybox);
                    break;
                default:
                    break;
            }

            //    var trees = new Scrollingbackgrounds(TextureHandler.Instance.TreesTexture, player, 60f);
            //    trees.Layer = 0.99f;
            //    pinkBackgrounds.Add(trees);

            //    var floor = new Scrollingbackgrounds(TextureHandler.Instance.FloorTexture, player, 60f);    
            //    floor.Layer = 0.9f;
            //    pinkBackgrounds.Add(floor);

            //    var hillsFront = new Scrollingbackgrounds(TextureHandler.Instance.hillsFrontTexture, player, 40f);
            //    hillsFront.Layer = 0.8f;
            //    pinkBackgrounds.Add(hillsFront);

            //    var hillsMiddle = new Scrollingbackgrounds(TextureHandler.Instance.hillsMiddleTexture, player, 30f);
            //    hillsMiddle.Layer = 0.79f;
            //    pinkBackgrounds.Add(hillsMiddle);

            //    var cloudsFast = new Scrollingbackgrounds(TextureHandler.Instance.cloudsFastTexture, player, 25f, true);
            //    cloudsFast.Layer = 0.78f;
            //    pinkBackgrounds.Add(cloudsFast);

            //    var hillsBack = new Scrollingbackgrounds(TextureHandler.Instance.hillsBackTexture, player, 0f);
            //    hillsBack.Layer = 0.77f;
            //    pinkBackgrounds.Add(hillsBack);

            //    var cloudsSlow = new Scrollingbackgrounds(TextureHandler.Instance.cloudsSlowTexture, player, 10f, true);
            //    cloudsSlow.Layer = 0.7f;
            //    pinkBackgrounds.Add(cloudsSlow);

            //    var sky = new Scrollingbackgrounds(TextureHandler.Instance.skyTexture, player, 0f);
            //    sky.Layer = 0.1f;
            //    pinkBackgrounds.Add(sky);

            
        }

        internal void Update(GameTime gameTime, float playerVelocityX)
        {
            foreach (var backgroundLayer in backgrounds) backgroundLayer.Update(gameTime, playerVelocityX);
        }
        internal void Draw(SpriteBatch spriteBatch)
        {
            foreach (var backgroundLayer in backgrounds.OrderBy(x => x.Layer)) backgroundLayer.Draw(spriteBatch);
        }
    }
}
