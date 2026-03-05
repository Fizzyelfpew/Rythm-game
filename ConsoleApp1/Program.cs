using Raylib_cs;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        // Start
    
        Raylib.InitWindow(1200, 750, "Skyrush");
        Raylib.SetTargetFPS(60);
        Vector2 Player = new Vector2(400, 225);
        // Texture2D cloud=Texture.cloud();
        Texture2D cloud = Raylib.LoadTexture("nuvem.png");
        Rectangle cloudRectangle = new(400, 225, cloud.Dimensions);
        while (!Raylib.WindowShouldClose())
        {
        // Input
            if(Raylib.IsKeyPressed(KeyboardKey.H)) ; 
            if(Raylib.IsKeyPressed(KeyboardKey.J)) ; 
            if(Raylib.IsKeyPressed(KeyboardKey.K)) ; 
            if(Raylib.IsKeyPressed(KeyboardKey.L)) ; 

        //Drawing
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.SkyBlue);

            Raylib.DrawTexture(cloud, (int)cloudRectangle.X, (int)cloudRectangle.Y, Color.White);
            Raylib.EndDrawing();
        
        }
        Raylib.CloseWindow();
    }
}
