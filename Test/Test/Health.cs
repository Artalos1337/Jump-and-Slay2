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
    class Health
    {
        Texture2D ball;
        Rectangle dest_Rect;
        Rectangle source_Rect;
        Vector2 position;
        //Test
        Tasten_Input T_Input;
        int ball_value_Y = 100;

        public Health(ContentManager content)
        {

            ball = content.Load<Texture2D>("KugelRot");
            dest_Rect = new Rectangle(90,90, 100, 100);
            source_Rect = new Rectangle(0,0,100,100);
            T_Input = new Tasten_Input();
        }

        public void Update(GameTime gameTime)
        {
            dest_Rect.Height = ball_value_Y;
            T_Input.Update(gameTime);
            if (T_Input.Tastendruck(Keys.X))
            {


                source_Rect.Y = source_Rect.Y + 1;
                ball_value_Y = ball_value_Y - 3;
                
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //spriteBatch.Draw(ball, dest_Rect,source_Rect, Color.White);
        }
    }
}
