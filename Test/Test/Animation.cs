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
    public class Animation
    {
        Texture2D Tex;
        float speed;
        float elapsed = 200;
        int f_count;
        int current_frame;
        int width_size, height_size;
        bool islooped, isdrawing, lastframe, Flipped;
        public Rectangle V_rect, S_rect;
        


        public Animation(Texture2D tex, int width, int height, int count,
            float frame_speed, bool looped, bool lastframe_on, bool flipped)
        {
            Tex = tex;
            f_count = count;
            width_size = width;
            height_size = height;
            speed = frame_speed;
            //Position = position;
            
            islooped = looped;
            lastframe = lastframe_on;
            isdrawing = true;
            Flipped = flipped;
        }

        public void Update(GameTime gameTime)
        {
            //V_rect.X = (int)Position.X;
            //V_rect.Y = (int)Position.Y;


            V_rect.Height = height_size;
            V_rect.Width = width_size / f_count;
            S_rect.Width = V_rect.Width;
            S_rect.Height = height_size;
            S_rect.Y = 0;
            S_rect.X = current_frame * V_rect.Width;

            elapsed -= (int)gameTime.ElapsedGameTime.TotalMilliseconds * speed;

            switch (islooped)
            {
                case true:
                    lastframe = false;
                    if (elapsed <= 0)
                    {
                        if (current_frame <= f_count - 2)
                        {
                            current_frame++;
                        }
                        else { current_frame = 0; }
                        elapsed = 200;
                    }
                    break;
                case false:
                    if (elapsed <= 0)
                    {
                        if (current_frame <= f_count - 2)
                        {
                            current_frame++;
                        }
                        else { if (!lastframe) { isdrawing = false; } }
                        elapsed = 200;
                    }
                    break;
            }

        }


        public void Draw(SpriteBatch spriteBatch, Rectangle rect)
        {
            V_rect = rect;
            switch (islooped)
            {
                case true:
                    if (!Flipped)
                    {
                        spriteBatch.Draw(Tex, V_rect, S_rect, Color.White);
                    }
                    else { spriteBatch.Draw(Tex, V_rect, S_rect, Color.White, 0f, new Vector2(0, 0), SpriteEffects.FlipHorizontally, 0); }

                    break;
                case false:
                    if (isdrawing)
                    {
                        if (!Flipped)
                        {
                            spriteBatch.Draw(Tex, V_rect, S_rect, Color.White);
                        }
                        else { spriteBatch.Draw(Tex, V_rect, S_rect, Color.White, 0f, new Vector2(0, 0), SpriteEffects.FlipHorizontally, 0); }
                    }
                    break;
            }
        }
    }
}
