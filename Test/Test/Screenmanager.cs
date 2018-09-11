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
    class Screenmanager
    {
        enum Statemachine{ Splash, Menu, Option, SaveGame, Intro, Hub, Pause, Inventory, Level_1 };

        Statemachine current_State;
        Tasten_Input Input;
        TimeSpan timer_splash ,timer_intro;
        Splash splash;
        public Menu menu;
        Intro intro;
        Option option;
        SaveGame savegame;
        Level_1 level_1;
        Camera camera;
        

        public Screenmanager()
        {
            timer_splash = TimeSpan.FromSeconds(5);
            timer_intro = TimeSpan.FromSeconds(5);
            current_State = Statemachine.Splash;
            Input = new Tasten_Input();
            splash = new Splash();
            menu = new Menu();
            intro = new Intro();
            option = new Option();
            savegame = new SaveGame();
            level_1 = new Level_1();
            camera = new Camera();
        }


        public void Load(ContentManager content)
        {
            splash.Load(content);
            menu.Load(content);
            intro.Load(content);
            option.Load(content);
            savegame.Load(content);
            level_1.Load(content);
        }


        public void Update(GameTime gameTime)
        {
            Input.Update(gameTime);

            switch (current_State)
            {
                case Statemachine.Splash:
                    //Update Splash Klasse
                    timer_splash -= gameTime.ElapsedGameTime;
                    if (Input.Tastendruck(Keys.Enter) || timer_splash < TimeSpan.Zero)
                    {
                        current_State = Statemachine.Menu;
                    }
                    break;
                case Statemachine.Menu:
                    menu.Update(gameTime);
                    if(menu.current_Button == Menu.ButtonState.NewGame && Input.Tastendruck(Keys.Enter))
                    {
                        current_State = Statemachine.Intro;
                    }
                    if (menu.current_Button == Menu.ButtonState.Option && Input.Tastendruck(Keys.Enter))
                    {
                        current_State = Statemachine.Option;
                    }
                    if (menu.current_Button == Menu.ButtonState.Load && Input.Tastendruck(Keys.Enter))
                    {
                        current_State = Statemachine.SaveGame;
                    }
                    break;
                case Statemachine.Option:
                    option.Update(gameTime);
                    break;
                case Statemachine.SaveGame:
                    
                    break;
                case Statemachine.Intro:
                    timer_intro -= gameTime.ElapsedGameTime;
                    if (Input.Tastendruck(Keys.Enter) || timer_intro < TimeSpan.Zero)
                    {
                        timer_intro = TimeSpan.FromSeconds(5);
                        current_State = Statemachine.Level_1;
                    }
                    break;
                case Statemachine.Hub:
                    break;
                case Statemachine.Pause:
                    break;
                case Statemachine.Inventory:
                    break;
                case Statemachine.Level_1:
                    level_1.Update(gameTime, camera);
                    break;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            switch (current_State)
            {
                case Statemachine.Splash:
                    //SpriteBatch Splash Klasse
                    splash.Draw(spriteBatch);
                    break;
                case Statemachine.Menu:
                    menu.Draw(spriteBatch);
                    break;
                case Statemachine.Option:
                    option.Draw(spriteBatch);
                    break;
                case Statemachine.SaveGame:
                    savegame.Draw(spriteBatch);
                    break;
                case Statemachine.Intro:
                    intro.Draw(spriteBatch);
                    break;
                case Statemachine.Hub:
                    break;
                case Statemachine.Pause:
                    break;
                case Statemachine.Inventory:
                    break;
                case Statemachine.Level_1:
                    level_1.Draw(spriteBatch);
                    break;
            }
        }
    }

}

