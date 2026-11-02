// Include the namespaces (code libraries) you need below.
using GAME_10033_Game_Development_Foundations___2D_Game_Template__v1._6_3;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        Fish fish1 = new Fish();


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(600, 600);
            Window.SetTitle("Fish Game");

            fish1.setup();

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Blue);

            fish1.update();
        }





    }
}


