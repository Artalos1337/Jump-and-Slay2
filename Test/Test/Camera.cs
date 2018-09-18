using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
   public class Camera
    {
        public Matrix Transform { get;  set; }
        
        //Commit

        public void Follow(Vector2 Position)
        {
            //var position = Matrix.CreateTranslation(
            //    -target.position.X - (target.player_rect.Width / 2),
            //    -target.position.Y - (target.player_rect.Height / 2),
            //    0);

            var offset = Matrix.CreateTranslation(
                Game1.ScreenWidth / 2,
                Game1.ScreenHeight / 2,
                0);

          var  position = Matrix.CreateTranslation(new Vector3(-Position.X, -Position.Y, 0));

            Transform = position * offset;

            //offset =  Matrix.CreateTranslation(new Vector3(bounds.Width * 0.5f, bounds.Height * 0.5f, 0)
            //  );

        }

        public Vector2 TranslatedPicture(Vector2 Pos)
        {
            return Vector2.Transform(new Vector2(Pos.X, Pos.Y), Matrix.Invert(Transform));
        }


    }
}


/// <summary>
/// This method is used to get the Mouseposition on the world, translated by the camera. If
/// the camera is moved, the position of the mouse in the world will change as well.
/// </summary>
/// <returns>A Vector2 for the translated MousePosition.</returns>
/// 

//public Vector2 TranslatedCursorPosition()
//{
//    return Vector2.Transform(new Vector2(Mouse.GetState().X, Mouse.GetState().Y), Matrix.Invert(transformMatrix));
//}