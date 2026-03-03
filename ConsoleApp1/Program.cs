using Raylib_cs;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
class program
{
    static void Main()
    {
        // Start
    
        Raylib.InitWindow(1200, 750, "Skyrush");
        Raylib.SetTargetFPS(60);
        Texture2D cloud = Raylib.LoadTexture(@"nuvem.png");
        Vector2 Player = new Vector2(400, 225);

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
            Raylib.DrawTexture(cloud, 200, 100, Color.White);
            
            Raylib.EndDrawing();
        
        }
        Raylib.CloseWindow();
    }
}