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
    public class Collision_Rect
    {
        
        public Rectangle Border_right, Border_left, Border_up, Border_down;
        Rectangle Col_Rect;
        Texture2D blanc_image;

        public bool coll_left;
        public bool coll_right;
        public bool coll_up;
        public bool coll_down = false;
        
        
        

        public Collision_Rect(int posx, int posy, int width, int height, ContentManager content )
        {
            Col_Rect = new Rectangle(posx, posy, width, height);
            Border_right = new Rectangle(posx + width - (width/4), posy,(width/4), height);
            Border_left = new Rectangle(posx , posy, (width / 4), height);
            Border_up = new Rectangle(posx, posy, width, (height/4));
            Border_down = new Rectangle(posx,posy + height - (height/4),width, (height/4));
            blanc_image = content.Load<Texture2D>("/blanc_image");
        }

        public void Update(GameTime gameTime, Rectangle player_border_L, Rectangle player_border_R, 
            Rectangle player_border_T, Rectangle player_border_D)
        {
            if (Border_up.Intersects(player_border_D))
            {
                coll_down = true;
            }
            else { coll_down = false; }

            if (Border_down.Intersects(player_border_T))
            {
                coll_up = true;
            }
            else { coll_up = false; }

            if (Border_right.Intersects(player_border_L))
            {
                coll_left = true;
            }
            else { coll_left = false; }

            if (Border_left.Intersects(player_border_R))
            {
                coll_right = true;
                
            }
            else { coll_right = false; }
            
        }

       // Debug
       public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(blanc_image, Border_right, Color.Red);
            spriteBatch.Draw(blanc_image, Border_left, Color.Green);
            spriteBatch.Draw(blanc_image, Border_up, Color.Blue);
            spriteBatch.Draw(blanc_image, Border_down, Color.Orange);
        }
    }
}
