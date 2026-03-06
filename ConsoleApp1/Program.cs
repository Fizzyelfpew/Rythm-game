using Raylib_cs;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        // Start
    
        Raylib.InitWindow(1200, 800, "Skyrush");
        Raylib.SetTargetFPS(60);
        Vector2 Player = new Vector2(400, 225);
        // Texture2D cloud=Texture.cloud();
        Texture2D cloud = Texture.Cloud();
        Hunter.texture = Texture.Hunter();
        Rectangle hunterrectangle = new(100,700, Hunter.texture.Dimensions);

        Rectangle cloudRectangle = new(1000, 225, cloud.Dimensions);
        Rectangle cloudRectangle2 = new(200, 125, cloud.Dimensions);
        

        while (!Raylib.WindowShouldClose())
        {
        // Input
        Hunter.hunterIdleAnimation();

        //Drawing
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.SkyBlue);
            Raylib.EndDrawing();
            Texture.Cloudsize1(cloud);
            Texture.Cloudsize2(cloud);
            Frame_animation.Hunter_shooting();

        }
        Raylib.CloseWindow();
    }
}
