using System.Numerics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonogGamef_rstasak
{
    public class Enemy : BaseClass
    {
       

        public Enemy(Texture2D texture, Microsoft.Xna.Framework.Vector2 position)
            :base(texture, position)
        {
            color = Color.Black;
        }

        public void Update()
        {
            while(position.Y <= 0)
            {
                position.Y--;
            }                     
            while(position.Y >= 400)
            {
                position.Y++; 
            }  
                         
            
        }
    }
}