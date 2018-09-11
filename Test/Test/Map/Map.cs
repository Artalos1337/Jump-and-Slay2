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
    public class Map
    {

        private List<Tile> Tiles = new List<Tile>();
        private List<Collision_Rect> Colls = new List<Collision_Rect>();
        private List<Trap> Traps = new List<Trap>();
        Collision_Rect tr;
        
        ContentManager Content;
        public int width, height;
        public int c_gap;


        public void Map_Load(ContentManager content)
        {
            Content = content;
            
        }

        public void createMap(int[,] map, int size)
        {

            for (int x = 0; x < map.GetLength(1); x++)
            {
                for (int y = 0; y < map.GetLength(0); y++)
                {
                    int number = map[y, x];    
                    // Für mehr Tiles, diesen Part klonen
                    if( number == 1)
                    {
                        Tiles.Add(new Tile(new Rectangle(x*size,y*size,size,size), number, Content));
                        
                    }
                    if (number == 2)
                    {
                        Tiles.Add(new Tile(new Rectangle(x* size, y*size, size, size), number, Content));
                        Colls.Add(new Collision_Rect(x * size, y * size, size, size, Content));                      
                    }
                    if (number == 4)
                    {
                        Tiles.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content));
                        Colls.Add(new Collision_Rect(x * size, y * size, size, size, Content));
                    }
                    if (number == 5)
                    {
                        Tiles.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content));
                        Colls.Add(new Collision_Rect(x * size, y * size, size, size, Content));
                    }
                    if (number == 7)
                    {
                        Tiles.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content));
                        Colls.Add(new Collision_Rect(x * size, y * size, size, size, Content));
                    }
                    if (number == 8)
                    {
                        Tiles.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content));
                        Colls.Add(new Collision_Rect(x * size, y * size, size, size, Content));
                    }
                    if (number == 9)
                    {
                        Tiles.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content));
                        Colls.Add(new Collision_Rect(x * size, y * size, size, size, Content));
                    }
                    // Fallen
                    if (number == 3)
                    {
                        Traps.Add(new Trap(new Rectangle(x * size, y * size, size, size ),number, Content));
                    }
                    if (number == 6)
                    {
                        Traps.Add(new Trap(new Rectangle(x * size, y * size, size, size), number, Content));
                    }


                    width = (x + 1) * size;
                    height = (y + 1) * size;
                }
            }
        }

       

        public void Update(Player p, GameTime gameTime)
        {
            // Collider Update
            foreach (Collision_Rect cr in Colls)
            {
                cr.Update(gameTime, p.border_left, p.border_right, p.border_top, p.border_down);
            }

            // Traps Update
            foreach (Trap t in Traps)
            {
                t.Update(gameTime, p.player_rect);
            }
           foreach(Trap t in Traps)
            {
                if (t.damaged)
                {
                    p.current = Player.PlayerState.Death;
                }
            }

            

            foreach (Collision_Rect cr in Colls)
            {
               Console.WriteLine(cr.coll_down);
                if (cr.coll_down)
                {
                    p.position.Y = cr.Border_up.Y - p.TestSprite.Height;
                    p.Block_D = false;
                    p.jump_available = true; 
                    
                }             
             }

          
          

            foreach (Collision_Rect cr in Colls)
            {
                if (cr.coll_left) { p.Block_R = true; break; } else { p.Block_R = false; }
            }
            foreach (Collision_Rect cr in Colls)
            {              
                if (cr.coll_right) { p.Block_L = true; break; } else { p.Block_L = false; }
            }
            foreach (Collision_Rect cr in Colls)
            {
                if (cr.coll_up) { p.Block_U = true;
                    p.position.Y = cr.Border_down.Y + 26;
                    break; } else { p.Block_U = false; }
            }

         
        }
           

            public void Draw(SpriteBatch spriteBatch)
            {

            foreach (Tile t in Tiles)
            {
                t.Draw(spriteBatch);
            }
            foreach(Trap t in Traps)
            {
                t.Draw(spriteBatch);
            }

            // Debug für Tile Borders
            //foreach (Collision_Rect cr in Colls)
            //{
            //    cr.Draw(spriteBatch);
            //}
        }
    }
}

