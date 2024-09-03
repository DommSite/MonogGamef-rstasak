using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonogGamef_rstasak
{
    public class BaseClass
    {
        protected Vector2   position;
        protected Texture2D texture;
        protected Color     color;

        public BaseClass(Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            this.position = position;
            color = Color.White;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle rectangle = new Rectangle((int)position.X, (int)position.Y, 100, 100);           
            spriteBatch.Draw(texture, rectangle, color);
        }
    }
}