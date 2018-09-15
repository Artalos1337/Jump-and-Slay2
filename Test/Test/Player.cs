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
    public class Player
    {
        public enum PlayerState { Idle, Run_L, Run_R, Jump, Death};
        public PlayerState current;
        Animation Idle, IdleL, Run, RunL, Jump, JumpL, Attack; 
        public  Texture2D TestSprite,blanc_image, death_tex;
        Vector2 velocity;
        private TimeSpan jump_timer = TimeSpan.FromMilliseconds(30);
        public Vector2 position;
        public Rectangle player_rect;
        public Rectangle border_left, border_right, border_top, border_down;
        public Rectangle Collision_border;
        public float gravity;
        private int border_margin = 8;
        private Tasten_Input T_input;
        public bool J_acceleration;
        private bool flipped;
        public bool Block_L, Block_R, Block_U, Block_D = true, jump_available;


     
        public Player()
        {
            player_rect = new Rectangle();
            border_left = new Rectangle();
            border_right = new Rectangle();
            border_top = new Rectangle();
            border_down = new Rectangle();
            Collision_border = new Rectangle();
            T_input = new Tasten_Input();
            current = PlayerState.Idle;
            jump_available = true;
            position = new Vector2(100,100);


        }

   public void Load(ContentManager content)
        {
            Idle = new Animation(content.Load<Texture2D>("Idle"), 3076, 369, 10, 0.3f, true, false, false);
            IdleL = new Animation(content.Load<Texture2D>("Idle"), 3076, 369, 10, 0.3f, true, false, true);
            Run = new Animation(content.Load<Texture2D>("Walk"), 3081, 369, 10, 1.3f, true, false,false);
            RunL = new Animation(content.Load<Texture2D>("Walk"), 3081, 369, 10, 1.3f, true, false, true);
            //position = new Vector2(100,80);
            
            TestSprite = content.Load<Texture2D>("TestSprite");
            blanc_image = content.Load<Texture2D>("blanc_image");
            death_tex = content.Load<Texture2D>("death_image");
          
            player_rect.Width = TestSprite.Width;
            player_rect.Height = TestSprite.Height;
            border_left.Width = TestSprite.Width / 4;
            border_left.Height = TestSprite.Height;
            border_right.Width = TestSprite.Width / 4;
            border_right.Height = TestSprite.Height;
            border_top.Width = TestSprite.Width;
            border_top.Height = TestSprite.Height/4;
            border_down.Width = TestSprite.Width;
            border_down.Height = TestSprite.Height/4;
            Collision_border.Width = 200;
            Collision_border.Height = 200;
            
          
        }
        public void Update(GameTime gameTime)
        {
          
            player_rect.X = (int)position.X;
            player_rect.Y = (int)position.Y;
            Collision_border.X = (int)position.X + TestSprite.Width / 2 - 100;
            Collision_border.Y = (int)position.Y + TestSprite.Height / 2 - 100;

            border_left.X = (int)position.X - border_margin;
            border_left.Y = (int)position.Y;
            border_right.X = (int)position.X + TestSprite.Width - (TestSprite.Width/4) + border_margin;
            border_right.Y = (int)position.Y;
            border_top.X = (int)position.X;
            border_top.Y = (int)position.Y - border_margin;
            border_down.X = (int)position.X;
            border_down.Y = (int)position.Y + TestSprite.Height - (TestSprite.Height/4);
            T_input.Update(gameTime);



            if (Block_D)
            {
                gravity += (9.81f / 600) * gameTime.ElapsedGameTime.Milliseconds;
            }
            else gravity = 0;
            
        

            if (Block_U)
            {
                gravity = 0;
                J_acceleration = false;
            }

            Run.Update(gameTime);
            RunL.Update(gameTime);
            

            switch (current)
            {
                case PlayerState.Idle:
                    velocity.X = 0f;
                    
                    if (flipped)
                    {
                        IdleL.Update(gameTime);
                    }
                     else Idle.Update(gameTime);
                    break;
                case PlayerState.Run_L:
                    flipped = true;
                    if (!Block_R) { velocity.X = -4f; } else { velocity.X = 0f; }                
                    if (Keyboard.GetState().IsKeyUp(Keys.A))
                    {
                        current = PlayerState.Idle;
                    }
                    break;
                case PlayerState.Run_R:
                    flipped = false;
                    if (!Block_L) { velocity.X = 4f; }else { velocity.X = 0f; }
                    if (Keyboard.GetState().IsKeyUp(Keys.D))
                    {
                        current = PlayerState.Idle;
                    }
                    break;
                case PlayerState.Jump:
                    jump_available = true;
                    break;
                case PlayerState.Death:
                    velocity.X = 0f;
                    break;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.D) && !(current == PlayerState.Death))
            {
                current = PlayerState.Run_R;
               
            }         
            if (Keyboard.GetState().IsKeyDown(Keys.A) && !(current == PlayerState.Death))
            {
                current = PlayerState.Run_L;
                
            }

            if (T_input.Tastendruck(Keys.W) && !(current == PlayerState.Death) && !Block_D && jump_available)
            {
                J_acceleration = true;
                jump_available = false;

            }

            if (J_acceleration)
            {
                jump_timer -= gameTime.ElapsedGameTime;
                gravity -= 4.4f;
                Block_D = true;

                if (jump_timer < TimeSpan.Zero)
                {
                    
                    J_acceleration = false;
                    jump_timer = TimeSpan.FromMilliseconds(30);
                }
            }
            
            position += velocity;
            velocity.Y = gravity;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            switch (current)
            {
                case PlayerState.Idle:
                    if (flipped)
                    {
                        IdleL.Draw(spriteBatch, player_rect);
                    }
                    else Idle.Draw(spriteBatch, player_rect);
                    break;
                case PlayerState.Run_L:
                    
                    RunL.Draw(spriteBatch, player_rect);
                    break;
                case PlayerState.Run_R:
                    
                    Run.Draw(spriteBatch, player_rect);
                    break;
                case PlayerState.Jump:
                    // Idle Test
                    spriteBatch.Draw(TestSprite, player_rect, Color.White);
                    break;
                case PlayerState.Death:
                    spriteBatch.Draw(death_tex, player_rect, Color.White);
                    break;
            }



            // DEBUG

            spriteBatch.Draw(blanc_image, border_left, Color.Aqua);
            spriteBatch.Draw(blanc_image, border_right, Color.Aqua);
            spriteBatch.Draw(blanc_image, border_top, Color.Aqua);
            spriteBatch.Draw(blanc_image, border_down, Color.Aqua);
            spriteBatch.Draw(blanc_image, Collision_border, Color.Violet);
        }
    }
}
