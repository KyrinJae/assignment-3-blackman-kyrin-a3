// Include the namespaces (code libraries) you need below.
// The namespace your code is in.
using System.Numerics;

namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///  
        /// </summary>
        public void Setup()
        {
            Window.SetSize(400, 400);
            Window.ClearBackground(Color.White);

        }

        /// <summary>
        ///    
        /// </summary>
        public void Update()
        {
            ///Draw body of whale 
            
            int Height = 65;
            int x = 200;
            int y = 230;

            Draw.SetFillColor(Color.Blue);
            Draw.Circle(new Vector2(200, 200), 30);
            Draw.Rectangle(new Vector2(x - 20, 95 + Height), new Vector2(Height, 30));

            ///Whale head
            Draw.Circle(new Vector2(245, 200), 25);
            Draw.SetFillColor(Color.Black);
            Draw.Circle(new Vector2(250, 190), 3);



            /// fin
            Draw.SetFillColor(Color.Blue);
            Draw.Triangle(
                new Vector2(210, 215),
                new Vector2(195, 240),
                new Vector2(230, 215));

            Draw.Triangle(
new Vector2(175, 200),
new Vector2(140, 175),
new Vector2(140, 225)
);














        }
    }

}
