using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Map
    {

        ///*private List<Tile> Tiles = new List<Tile>()*/;
        private List<Collision_Rect> Colls = new List<Collision_Rect>();
        private List<Trap> Traps = new List<Trap>();
        public List<Tile> Tiles = new List<Tile>();
        public List<Tile> Layer = new List<Tile>();
        public List<Tile> Layer_2 = new List<Tile>();
        public List<Point> Points = new List<Point>();
        Point point;

        ContentManager Content;
        public int width, height;
        public int c_gap;
     


        public void Map_Load(ContentManager content)
        {
            Content = content;

        }

        public void createMap(Player p, int[,] map, int size)
        {

            for (int x = 0; x < map.GetLength(1); x++)
            {
                for (int y = 0; y < map.GetLength(0); y++)
                {
                    int number = map[y, x];



                    if (number == 1)
                    {
                        Tiles.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "Graveyard"));

                        Points.Add(point);

                        if (p.Collision_border.Contains(point))
                        {
                            Colls.Add(new Collision_Rect(x * size, y * size, size, size, Content));

                        }
                        else
                        {
                            Colls.RemoveRange(0, 4);
                        }
                        if (number == 2)
                        {
                            Tiles.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "Graveyard"));
                            Points.Add(point);

                            if (p.Collision_border.Contains(point))
                            {
                                Colls.Add(new Collision_Rect(x * size, y * size, size, size, Content));
                            }
                        }

                        if (number == 3)
                        {
                            Tiles.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "Graveyard"));
                            Points.Add(point);

                            if (p.Collision_border.Contains(point))
                            {
                                Colls.Add(new Collision_Rect(x * size, y * size, size, size, Content));
                            }
                        }

                        if (number == 4)
                        {
                            Tiles.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "Graveyard"));

                            Points.Add(point);

                            if (p.Collision_border.Contains(point))
                            {
                                Colls.Add(new Collision_Rect(x * size, y * size, size, size, Content));
                            }

                        }

                        if (number == 5)
                        {
                            Tiles.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "Graveyard"));
                            Points.Add(point);

                            if (p.Collision_border.Contains(point))
                            {
                                Colls.Add(new Collision_Rect(x * size, y * size, size, size, Content));
                            }
                        }

                        if (number == 6)
                        {
                            Tiles.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "Graveyard"));
                            Points.Add(point);

                            if (p.Collision_border.Contains(point))
                            {
                                Colls.Add(new Collision_Rect(x * size, y * size, size, size, Content));
                            }
                        }

                        if (number == 7)
                        {
                            Tiles.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "Graveyard"));
                        }

                        if (number == 8)
                        {
                            Tiles.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "Graveyard"));
                            Points.Add(point);

                            if (p.Collision_border.Contains(point))
                            {
                                Colls.Add(new Collision_Rect(x * size, y * size, size, size, Content));
                            }
                        }

                        if (number == 9)
                        {
                            Tiles.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "Graveyard"));
                            Points.Add(point);

                            if (p.Collision_border.Contains(point))
                            {
                                Colls.Add(new Collision_Rect(x * size, y * size, size, size, Content));
                            }
                        }



                        if (number == 10)
                        {
                            Tiles.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "Graveyard"));
                            Points.Add(point);

                            if (p.Collision_border.Contains(point))
                            {
                                Colls.Add(new Collision_Rect(x * size, y * size, size, size, Content));
                            }
                        }


                        if (number == 11)
                        {
                            Tiles.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "Graveyard"));
                            Points.Add(point);

                            if (p.Collision_border.Contains(point))
                            {
                                Colls.Add(new Collision_Rect(x * size, y * size, size, size, Content));
                            }
                        }


                        if (number == 13)
                        {
                            Tiles.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "Graveyard"));
                            Points.Add(point);

                            if (p.Collision_border.Contains(point))
                            {
                                Colls.Add(new Collision_Rect(x * size, y * size, size, size, Content));
                            }
                        }

                        if (number == 14)
                        {
                            Tiles.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "Graveyard"));
                            Points.Add(point);

                            if (p.Collision_border.Contains(point))
                            {
                                Colls.Add(new Collision_Rect(x * size, y * size, size, size, Content));
                            }
                        }


                        if (number == 15)
                        {
                            Tiles.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "Graveyard"));
                            Points.Add(point);

                            if (p.Collision_border.Contains(point))
                            {
                                Colls.Add(new Collision_Rect(x * size, y * size, size, size, Content));
                            }
                        }

                        if (number == 16)
                        {
                            Tiles.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "Graveyard"));
                            Points.Add(point);

                            if (p.Collision_border.Contains(point))
                            {
                                Colls.Add(new Collision_Rect(x * size, y * size, size, size, Content));
                            }
                        }

                        if (number == 17)
                        {
                            Tiles.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "Graveyard"));
                            Points.Add(point);

                            if (p.Collision_border.Contains(point))
                            {
                                Colls.Add(new Collision_Rect(x * size, y * size, size, size, Content));
                            }
                        }


                        if (number == 18)
                        {
                            Tiles.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "Graveyard"));
                            Points.Add(point);

                            if (p.Collision_border.Contains(point))
                            {
                                Colls.Add(new Collision_Rect(x * size, y * size, size, size, Content));
                            }
                        }

                        if (number == 19)
                        {
                            Tiles.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "Graveyard"));
                            Points.Add(point);

                            if (p.Collision_border.Contains(point))
                            {
                                Colls.Add(new Collision_Rect(x * size, y * size, size, size, Content));
                            }
                        }

                        if (number == 20)
                        {
                            Tiles.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "Graveyard"));
                            Points.Add(point);

                            if (p.Collision_border.Contains(point))
                            {
                                Colls.Add(new Collision_Rect(x * size, y * size, size, size, Content));
                            }

                        }

                        width = (x + 1) * size;
                        height = (y + 1) * size;
                    }
                }
            }
        }

            public void createMapLayer2(int[,] map, int size)
            {

                for (int x = 0; x < map.GetLength(1); x++)
                {
                    for (int y = 0; y < map.GetLength(0); y++)
                    {
                        int number = map[y, x];


                        if (number == 18) // Bush_1
                        {
                            Layer.Add(new Tile(new Rectangle(x * size, y * size, size * 2, size), number, Content, "GraveYardLayer2"));
                        }


                        if (number == 17) // Zweier_Bone 
                        {
                            Layer.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "GraveYardLayer2"));
                        }


                        if (number == 46) // Tombstone_2
                        {
                            Layer.Add(new Tile(new Rectangle(x * size, y * size, size, size * 2), number, Content, "GraveYardLayer2"));
                        }

                        if (number == 48) // Arrow Sign
                        {
                            Layer.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "GraveYardLayer2"));
                        }

                        if (number == 15) // Sekelton Head
                        {
                            Layer.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "GraveYardLayer2"));
                        }


                        if (number == 66) // Dreier_Bone (30 Grad)
                        {
                            Layer.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "GraveYardLayer2"));
                        }


                        if (number == 16) // Dreier_Bone
                        {
                            Layer.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "GraveYardLayer2"));
                        }

                        if (number == 2) // Bush_2
                        {
                            Layer.Add(new Tile(new Rectangle(x * size, y * size, size * 2, size), number, Content, "GraveYardLayer2"));
                        }

                        if (number == 44) // Tombstone_1
                        {
                            Layer.Add(new Tile(new Rectangle(x * size, y * size, size, size * 2), number, Content, "GraveYardLayer2"));
                        }

                        if (number == 32) // Skeleton Leiche
                        {
                            Layer.Add(new Tile(new Rectangle(x * size, y * size, size * 2, size), number, Content, "GraveYardLayer2"));
                        }

                        if (number == 67) // Sekelton Head (180 Grad)
                        {
                            Layer.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "GraveYardLayer2"));
                        }

                        if (number == 68) // Dreier_ Bone (90 Grad)
                        {
                            Layer.Add(new Tile(new Rectangle(x * size, y * size, size, size), number, Content, "GraveYardLayer2"));
                        }

                        if (number == 20) // Baum
                        {
                            Layer.Add(new Tile(new Rectangle(x * size, y * size, size * 3, size * 4), number, Content, "GraveYardLayer2"));
                        }

                        width = (x + 1) * size;
                        height = (y + 1) * size;
                    }
                }
            }
            //TRAPS BABY 
            public void createMapLayer3(int[,] map, int size)
            {

                for (int x = 0; x < map.GetLength(1); x++)
                {
                    for (int y = 0; y < map.GetLength(0); y++)
                    {
                        int number = map[y, x];


                        if (number == 1) // Stacheln runter
                        {
                            Layer_2.Add(new Tile(new Rectangle(x * size, y * size, size * 2, size), number, Content, "GraveYardLayer3"));
                        }

                        if (number == 2) // Stacheln hoch
                        {
                            Layer_2.Add(new Tile(new Rectangle(x * size, y * size, size * 2, size), number, Content, "GraveYardLayer3"));
                        }

                        if (number == 3) // Stacheln seitlich
                        {
                            Layer_2.Add(new Tile(new Rectangle(x * size, y * size, size, size * 2), number, Content, "GraveYardLayer3"));
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
                foreach (Trap t in Traps)
                {
                    if (t.damaged)
                    {
                        p.current = Player.PlayerState.Death;
                    }
                }



                foreach (Collision_Rect cr in Colls)
                {

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
                    if (cr.coll_up)
                    {
                        p.Block_U = true;
                        p.position.Y = cr.Border_down.Y + 26;
                        break;
                    }
                    else { p.Block_U = false; }
                }


            }


            public void Draw(SpriteBatch spriteBatch)
            {

                foreach (Tile t in Tiles)
                {
                    t.Draw(spriteBatch);
                }
                foreach (Trap t in Traps)
                {
                    t.Draw(spriteBatch);
                }

                //Debug für Tile Borders
                foreach (Collision_Rect cr in Colls)
                {


                }
            }
        }
    } 

