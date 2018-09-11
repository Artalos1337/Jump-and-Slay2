using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Test
{
    public class GUI
    {
        Texture2D Skillbar;
        Texture2D Lifebar;
        Texture2D Manabar;

        Vector2 Skill_position,
                LifePoints_position,
                ManaPoints_position;

        public GUI()
        {

        }

        public Vector2 Skill_Position
        {
            get { return Skill_position; }
            set { Skill_position = value; }
        }

        public Vector2 LifePoints_Position
        {
            get { return LifePoints_position; }
            set { LifePoints_position = value; }
        }

        public Vector2 ManaPoints_Position
        {
            get { return ManaPoints_position; }
            set { ManaPoints_position = value; }
        }

        public void Load(ContentManager content)
        {
            Skillbar = content.Load<Texture2D>("GUI/GUI2");
            Lifebar = content.Load<Texture2D>("GUI/LifePoints");
            Manabar = content.Load<Texture2D>("GUI/Mana");
        }

        public void Draw(SpriteBatch spriteBatch,Camera _camera)
        {
            spriteBatch.Draw(Skillbar,_camera.TranslatedPicture(Skill_position), Color.White);
            spriteBatch.Draw(Lifebar, _camera.TranslatedPicture(LifePoints_position), Color.White);
            spriteBatch.Draw(Manabar, _camera.TranslatedPicture(ManaPoints_position), Color.White);
        }

    }
}
