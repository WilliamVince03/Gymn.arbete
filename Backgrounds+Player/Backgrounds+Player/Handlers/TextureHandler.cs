using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Backgrounds_Player
{
    public class TextureHandler
    {
        private static TextureHandler _instance = null;
        public int Theme { get; set; } = 1;
        //public Texture2D TreesTexture { get; set; }
        //public Texture2D FloorTexture { get; set; }
        //public Texture2D hillsFrontTexture { get; set; }
        //public Texture2D hillsMiddleTexture { get; set; }
        //public Texture2D cloudsFastTexture { get; set; }
        //public Texture2D hillsBackTexture { get; set; }
        //public Texture2D cloudsSlowTexture { get; set; } 
        //public Texture2D skyTexture { get; set; } 
        public Texture2D BoyTexture { get; set; }
        public Texture2D BoyTexture1 { get; set; }
        public Texture2D BoyTexture2 { get; set; }

        public Texture2D Houses { get; set; }
        public Texture2D Backhouses1 { get; set; }
        public Texture2D Backhouses2 { get; set; }
        public Texture2D Foreground { get; set; }
        public Texture2D Clouds1 { get; set; }
        public Texture2D Clouds2 { get; set; }
        public Texture2D Skybox { get; set; }





        public static TextureHandler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TextureHandler();
                }
                return _instance;
            }
        }

        private TextureHandler(){ }

        public void LoadTextures(ContentManager content) {



            BoyTexture1 = content.Load<Texture2D>("boy");
            BoyTexture2 = content.Load<Texture2D>("boy");
            BoyTexture = content.Load<Texture2D>("boy");

            Foreground = content.Load<Texture2D>("foreground");
            Houses = content.Load<Texture2D>("houses");
            Backhouses1 = content.Load<Texture2D>("_backhouses1");
            Backhouses2 = content.Load<Texture2D>("backhouses2");
            Clouds1 = content.Load<Texture2D>("clouds1 (3)");
            Clouds2 = content.Load<Texture2D>("clouds2 (3)");
            Skybox = content.Load<Texture2D>("skybox");


        }

        public Texture2D GetBoyTexture() // byt namn sen
        {
            switch (Theme)
            {
                case 1:
                    return BoyTexture1;

                case 2:
                    return BoyTexture2;

                default:
                    return BoyTexture;
            }
        }
    }
}
