using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;


namespace Test
{
    class Splash
    {
        Texture2D background;

        public Splash()
        {
            
        }

        public void Load(ContentManager content)
        {
            background = content.Load<Texture2D>("Splash");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(background, new Vector2(0, 0), Color.White);
        }
    }
}
