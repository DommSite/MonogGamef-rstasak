using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonogGamef_rstasak
{
    public class Player
    {
        Vector2 position = new Vector2(350, 190);
        Texture2D texture;

        public Player(Texture2D texture)
        {
            this.texture = texture;
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
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle playerRectangle = new Rectangle((int)position.X, (int)position.Y, 100, 100);           
            spriteBatch.Draw(texture, playerRectangle, Color.CornflowerBlue);
        }
    }
}