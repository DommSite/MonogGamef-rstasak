using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonogGamef_rstasak
{
    public class Player : BaseClass
    {
    
        public Player(Texture2D texture)
            :base(texture, new Vector2(350, 190))
        {
            color = Color.Green;
        }

        public void Update()
        {      
            KeyboardState kState = Keyboard.GetState();
            int speed = 5;
            if(kState.IsKeyDown(Keys.W))
            {
                position.Y -= speed;
            }
            if(kState.IsKeyDown(Keys.S))
            {
                position.Y += speed;
            }
            if(kState.IsKeyDown(Keys.A))
            {
                position.X -= speed;
            }
            if(kState.IsKeyDown(Keys.D))
            {
                position.X += speed;
            }
            if(kState.IsKeyDown(Keys.R))
            {
                position.X = 350;
                position.Y = 190;
            }
        }

    }
}