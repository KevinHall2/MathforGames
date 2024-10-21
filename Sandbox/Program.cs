using MathLibrary;
using Raylib_cs;


namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 450, "raylib [core] example - basic window");

            Vector2 screenDimensions = new MathLibrary.Vector2(Raylib.GetScreenWidth(), Raylib.GetScreenHeight());

            //player info
            Vector2 playerPosition = new Vector2(screenDimensions.x * 0.5f, screenDimensions.y * 0.75f);
            float playerRadius = 10;
            Vector2 playerForward = new Vector2(0, 1).Normalized;
            float playerSpeed = 50;

            //enemy info
            Vector2 enemyPosition = new Vector2(screenDimensions.x * 0.5f, screenDimensions.y * 0.5f);
            Color enemyColor = Color.Red;
            float enemyRadius = 10;


            float playerViewAngle = 90;
            float playerViewDistance = 300;

            Matrix3 testVector = new Matrix3(1, 2, 3, 3, 2, 1, 1, 2, 3);
            Matrix3 testVector2 = new Matrix3(4, 5, 6, 6, 5, 4, 4, 6, 5);
            Matrix3 matrixProduct = testVector - testVector2;
            Console.WriteLine(matrixProduct.ToString());

 
              while (!Raylib.WindowShouldClose())
              {
                //movement calculations

                Vector2 movementInput = new Vector2();
                movementInput.y -= Raylib.IsKeyDown(KeyboardKey.W);
                movementInput.y += Raylib.IsKeyDown(KeyboardKey.S);
                movementInput.x -= Raylib.IsKeyDown(KeyboardKey.A);
                movementInput.x += Raylib.IsKeyDown(KeyboardKey.D);

                playerPosition += movementInput * playerSpeed * Raylib.GetFrameTime();

                //LOS calculations
                playerPosition.x += 20 * Raylib.GetFrameTime();
                Vector2 playerToEnemyDirection = (playerPosition - enemyPosition).Normalized;
                float distance = enemyPosition.Distance(playerPosition);
                float angleToEnemy = (float)Math.Abs(Math.Acos(playerForward.DotProduct(playerToEnemyDirection))); 

                //if the enemy is in sight
                if (Math.Abs(angleToEnemy) < (playerViewAngle / 2) * (Math.PI / 180) && distance < playerViewDistance)
                {
                        enemyColor = Color.Purple;
                }
                else
                {
                   enemyColor = Color.Red;
                }
                    
                    
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);

                

                //drawing player forward
                Raylib.DrawLineV(playerPosition, playerPosition - (playerForward * 100), Color.Black);

                //drawing the player
                Raylib.DrawCircleV(playerPosition, playerRadius, Color.Red);

                //drawing the enemy
                Raylib.DrawCircleV(enemyPosition, enemyRadius, enemyColor);

                //drawing view cone
                Raylib.DrawCircleSectorLines(playerPosition, playerViewDistance, -90 - (playerViewAngle / 2), -90 + (playerViewAngle / 2), 10, Color.Blue);

                Raylib.EndDrawing();
              }  

             Raylib.CloseWindow();
            return;
               
        }

            
        
    }
}
