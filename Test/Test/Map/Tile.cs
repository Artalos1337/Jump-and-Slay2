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
   public class Tile
    {
        Texture2D texture;
        Rectangle Rect;
        

        public Tile(Rectangle rect, int index, ContentManager content)
        {
            texture = content.Load<Texture2D>("Tile" + index);
            Rect = rect;
            
        }

      

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, Rect, Color.White);
        }
    }
}
