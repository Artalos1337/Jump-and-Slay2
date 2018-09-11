using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Trap
    {
        Texture2D tex;
        Rectangle rect;
         public bool damaged;

        public Trap(Rectangle Rect, int index, ContentManager Content)
        {
            tex = Content.Load<Texture2D>("Trap" + index);
            rect = Rect;
        }

        public void Update(GameTime gameTime, Rectangle player_rect)
        {
            if (rect.Intersects(player_rect))
            {
                damaged = true;
            }
            else { damaged = false; }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, rect, Color.White);
        }
    }
}
