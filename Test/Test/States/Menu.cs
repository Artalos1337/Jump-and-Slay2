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
    class Menu
    {
        public enum ButtonState { NewGame, Load, Option, Exit};
        public ButtonState current_Button;
        Texture2D title_tex, NG_tex, L_tex, O_tex, E_tex, bg_tex, glow_tex;
        Rectangle Button_rect, Title_rect, glow_rect;
        Tasten_Input input;

        


        public Menu()
        {
            input = new Tasten_Input();
           
            glow_rect = new Rectangle();
          
            current_Button = ButtonState.NewGame;
        }
        public void Load(ContentManager content)
        {
            title_tex = content.Load<Texture2D>("Title_Image");
            NG_tex = content.Load<Texture2D>("NewGame_Button");
            L_tex = content.Load<Texture2D>("Load_Button");
            O_tex = content.Load<Texture2D>("Option_Button");
            E_tex = content.Load<Texture2D>("Exit_Button");
            bg_tex = content.Load<Texture2D>("Menu_Background");
            glow_tex = content.Load<Texture2D>("Glow_Button");
            Title_rect = new Rectangle(640 - (title_tex.Width / 2), 50, title_tex.Width, title_tex.Height);
            glow_rect.Width = glow_tex.Width;
            glow_rect.Height = glow_tex.Height;
            
        }
        public void Update(GameTime gameTime)
        {
            
            input.Update(gameTime);
            
            switch (current_Button)
            {
                case ButtonState.NewGame:
                    glow_rect.X = 640 - (glow_tex.Width / 2);
                    glow_rect.Y = 200;
                    if (input.Tastendruck(Microsoft.Xna.Framework.Input.Keys.Down))
                    {
                        current_Button = ButtonState.Load;
                    }
                    break;
                case ButtonState.Load:
                    glow_rect.X = 640 - (glow_tex.Width / 2);
                    glow_rect.Y = 325;
                    if (input.Tastendruck(Microsoft.Xna.Framework.Input.Keys.Down))
                    {
                        current_Button = ButtonState.Option;
                    }
                    if (input.Tastendruck(Microsoft.Xna.Framework.Input.Keys.Up))
                    {
                        current_Button = ButtonState.NewGame;
                    }
                    break;
                case ButtonState.Option:
                    glow_rect.X = 640 - (glow_tex.Width / 2);
                    glow_rect.Y = 450;
                    if (input.Tastendruck(Microsoft.Xna.Framework.Input.Keys.Down))
                    {
                        current_Button = ButtonState.Exit;
                    }
                    if (input.Tastendruck(Microsoft.Xna.Framework.Input.Keys.Up))
                    {
                        current_Button = ButtonState.Load;
                    }
                    break;
                case ButtonState.Exit:
                    glow_rect.X = 640 - (glow_tex.Width / 2);
                    glow_rect.Y = 575;
                    if (input.Tastendruck(Microsoft.Xna.Framework.Input.Keys.Up))
                    {
                        current_Button = ButtonState.Option;
                    }
                    break;
            }

            
            

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(bg_tex, new Vector2(0, 0), Color.White);
            spriteBatch.Draw(title_tex, Title_rect, Color.White);
            spriteBatch.Draw(NG_tex, new Rectangle(640 - (NG_tex.Width / 2), 200, 400,75), Color.White);
            spriteBatch.Draw(L_tex, new Rectangle(640 - (NG_tex.Width / 2), 325, 400, 75), Color.White);
            spriteBatch.Draw(O_tex, new Rectangle(640 - (NG_tex.Width / 2), 450, 400, 75), Color.White);
            spriteBatch.Draw(E_tex, new Rectangle(640 - (NG_tex.Width / 2), 575, 400, 75), Color.White);
            spriteBatch.Draw(glow_tex, glow_rect, Color.White);
        }
    }
}
