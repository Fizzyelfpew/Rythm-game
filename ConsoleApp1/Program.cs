using Raylib_cs;
using System.Numerics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
Main();
    static void Main()
    {
        // Start

        Raylib.InitWindow(1200, 800, "Skyrush");
        Raylib.SetTargetFPS(60);
        Texture2D bird = Raylib.LoadTexture(@"Bird.png");
        Texture2D cloud = Texture.Cloud();
        Hunter.texture = Texture.Hunter();
        Texture2D aim = Raylib.LoadTexture(@"aim.png");
        bool doingaction = false;
        int frametimelength = 0;
        int birdAnimation = 0;
        Rectangle birdspriteDest = new(450, 60, 128,128);
        Rectangle birdspriteDest1 = new(550, 60, 128,128);
        Rectangle birdspriteDest2 = new(650, 60, 128,128);
        Rectangle birdspriteDest3 = new(750, 60, 128,128);
        Rectangle aimspriteDest = new(450, 700, 64,64);
        Rectangle aimspriteDest1 = new(550, 700, 64,64);
        Rectangle aimspriteDest2 = new(650, 700, 64,64);
        Rectangle aimspriteDest3 = new(750, 700, 64,64);

        bool overlapping = Raylib.CheckCollisionRecs(birdspriteDest, aimspriteDest);
        bool overlapping1 = Raylib.CheckCollisionRecs(birdspriteDest1, aimspriteDest1);
        bool overlapping2 = Raylib.CheckCollisionRecs(birdspriteDest2, aimspriteDest2);
        bool overlapping3 = Raylib.CheckCollisionRecs(birdspriteDest3, aimspriteDest3);

        while (!Raylib.WindowShouldClose())
        {

        // Input
        //Drawing
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.SkyBlue);
            Texture.Cloudsize1(cloud);
            Texture.Cloudsize2(cloud);
            (frametimelength, doingaction) = Frame_animation.Hunter_shooting_Miss(cloud, frametimelength, doingaction, overlapping, overlapping1, overlapping2, overlapping3);
            birdAnimation = Frame_animation.Bird_animation(birdAnimation, bird, birdspriteDest);
            Frame_animation.Bird_animation(birdAnimation, bird, birdspriteDest1);
            Frame_animation.Bird_animation(birdAnimation, bird, birdspriteDest2);
            Frame_animation.Bird_animation(birdAnimation, bird, birdspriteDest3);
            Texture.Crosshair(aim, aimspriteDest); 
            Texture.Crosshair(aim, aimspriteDest1); 
            Texture.Crosshair(aim, aimspriteDest2); 
            Texture.Crosshair(aim, aimspriteDest3); 

            
            Raylib.EndDrawing();

        }
        Raylib.CloseWindow();
    }
