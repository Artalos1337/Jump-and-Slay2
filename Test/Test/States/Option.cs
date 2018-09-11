using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Option
    {
        Texture2D background;

        public Option()
        {

        }
        public void Update(GameTime gameTime)
        {

        }
        public void Load(ContentManager content)
        {
            background = content.Load<Texture2D>("Optionen");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(background, new Vector2(0, 0), Color.White);
        }
    }
}
