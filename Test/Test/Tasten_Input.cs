using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Tasten_Input
    {
        // Previous and current
        KeyboardState p_Key;
        KeyboardState c_Key;

        public bool Tastendruck(Keys key)
        {
            return (p_Key.IsKeyUp(key) && c_Key.IsKeyDown(key));
        }

        public void Update(GameTime gameTime)
        {
            p_Key = c_Key;
            c_Key = Keyboard.GetState();

        }
    }
}
