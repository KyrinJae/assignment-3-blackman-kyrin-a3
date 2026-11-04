using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using MohawkGame2D;

namespace GAME_10033_Game_Development_Foundations___2D_Game_Template__v1._6_3
{
    public class Fish
    {

        float x = 200.0f;
        float y = 200.0f;

        Color fishColor = Color.Red;



        float speed = 15.0f;

        Vector2 direction = new Vector2(0, 0);




        public void setup()
        { 

            fishColor = MohawkGame2D.Random.Color();
            speed = MohawkGame2D.Random.Float(500, 700);

            x = MohawkGame2D.Random.Float(400, 500);
            y = MohawkGame2D.Random.Float(400, 500);




        }

        public void update()
        {

            {

        {
            // Get keyboard input
            char key = Input.GetCharsPressed();

            // W - Move Up
            if (key == 'w' || key == 'W')
            {
                y -= speed * Time.DeltaTime;
            }

            // A - Move Left
            if (key == 'a' || key == 'A')
            {
                x -= speed * Time.DeltaTime;
            }

            // D - Move Right
            if (key == 'd' || key == 'D')
            {
                x += speed * Time.DeltaTime;
            }

            // Snap back when fish reaches right edge
            if (x > 650)
            {
                x = -50;
                fishColor = MohawkGame2D.Random.Color();
                speed = MohawkGame2D.Random.Float(400, 500);
                y = MohawkGame2D.Random.Float(50, 500);
            }

            // Snap back when fish reaches left edge
            if (x < -85)
            {
                x = 650;
                fishColor = MohawkGame2D.Random.Color();
                speed = MohawkGame2D.Random.Float(400, 500);
                y = MohawkGame2D.Random.Float(50, 500);
            }

            // Draw Fish
            DrawFish();
        }

    }



}

            

        
        void DrawFish()
            {
                int height = 30;

                // offset to center the origin
                Vector2 offset = new Vector2(-30, -height);

                // draw the tail of the fish


                Draw.Triangle(
                    new Vector2(x - 35, y),
                    new Vector2(x - 85, y - 35),
                    new Vector2(x - 85, y + 35)
                );

                // draw the top fin
                Draw.Triangle(
                    new Vector2(x - 20, y - 15),
                    new Vector2(x, y - 65),
                    new Vector2(x + 25, y - 15)
                );

                // draw the bottom fin
                Draw.Triangle(
                    new Vector2(x - 10, y + 15),
                    new Vector2(x + 10, y + 55),
                    new Vector2(x + 30, y + 15)
                );

                // draw the body of the fish
                Draw.LineSize = 0;
                Draw.FillColor = fishColor;

                Vector2 topRectPosition = new Vector2(x, y);
                topRectPosition += offset;

                Vector2 topRectSize = new Vector2(60, height);
                Draw.Rectangle(topRectPosition, topRectSize);

                Vector2 bottomRectPosition = new Vector2(x, y + height);
                bottomRectPosition += offset;

                Vector2 bottomRectSize = new Vector2(60, height);
                Draw.Rectangle(bottomRectPosition, bottomRectSize);

                // round out the fish body
                Draw.Circle(new Vector2(x - 30, y), 30);
                Draw.Circle(new Vector2(x + 30, y), 30);
                Draw.Rectangle(
                    new Vector2(x - 30, y - 30),
                    new Vector2(60, 60)
                );

                // draw the white belly
                Draw.FillColor = Color.White;

                Draw.Rectangle(
                    new Vector2(x - 20, y + 12),
                    new Vector2(55, 10)
                );

                // draw the side fin
                Draw.FillColor = fishColor;

                Draw.Triangle(
                    new Vector2(x - 5, y),
                    new Vector2(x - 20, y + 35),
                    new Vector2(x + 20, y + 10)
                );

                // draw the fish eye
                float eyeRadius = 8f;
                float eyeOffset = 35f;
                float heightOffset = 10f;

                Draw.FillColor = Color.White;

                Vector2 eyeCirclePos = new Vector2(x, y);
                eyeCirclePos.X += eyeOffset;
                eyeCirclePos.Y -= heightOffset;

                Draw.Circle(eyeCirclePos, eyeRadius);

                // draw the pupl of eye
                Draw.FillColor = Color.Black;
                Draw.Circle(eyeCirclePos, 4f);

                // draw the mouth
                Draw.FillColor = Color.Black;
                Draw.Rectangle(
                    new Vector2(x + 48, y + 10),
                    new Vector2(10, 3)
                );
            }
        }
    }

