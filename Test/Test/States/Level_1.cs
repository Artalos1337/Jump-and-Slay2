//using Microsoft.Xna.Framework;
//using Microsoft.Xna.Framework.Content;
//using Microsoft.Xna.Framework.Graphics;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Test
//{
//    class Level_1
//    {
//        Map map;
//        Player player;
//        Health health;
        

//        public void Load(ContentManager content)
//        {
            
//            player = new Player();
//            map = new Map();
//            health = new Health(content);
            
//            player.Load(content);
//            map.Map_Load(content);

//            map.createMap(new int[,]
//            {
//            // Nur 15 tiles breite but why
//            { 5,1,1,1,1,1,1,1,1,5,1,1,1,1,1, },
//            { 5,1,1,1,1,1,1,1,1,5,1,1,1,1,1, },
//            { 5,1,1,1,1,1,1,1,1,5,1,1,1,1,1, },
//            { 5,1,1,1,1,1,1,1,2,2,2,1,1,1,1, },
//            { 5,1,1,1,1,1,1,1,1,1,1,1,1,1,1, },
//            { 5,1,1,1,1,1,1,1,1,1,1,1,1,1,1, },
//            { 5,1,1,1,1,1,1,1,1,6,1,1,1,1,1, },
//            { 5,1,1,1,1,1,1,1,7,9,8,1,1,1,1, },
//            { 5,2,2,2,1,1,1,1,1,1,1,1,1,6,1, },
//            { 5,2,2,2,2,2,2,2,2,2,2,2,2,2,2, },

//        }, 72);
            
//        }

//        public void Update(GameTime gameTime, Camera camera)
//        {
          
//            player.Update(gameTime);
//            camera.Follow(player.position);
//             map.Update(player, gameTime);
//            health.Update(gameTime);
            
//        }

//        public void Draw(SpriteBatch spriteBatch)
//        {
//            map.Draw(spriteBatch);
//            player.Draw(spriteBatch);
//            health.Draw(spriteBatch);
            
            
//        }


//    }
//}
