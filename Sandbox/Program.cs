using MathLibrary;
using Raylib_cs;
using System.Numerics;

namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 450, "raylib [core] example - basic window");

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.Gray);
                Raylib.DrawRectangle(400, 225, 75, 75, Color.White);
                if (Raylib.IsKeyDown(KeyboardKey.W))
                {
                    
                }
                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();

            return;
        }
    }
}
