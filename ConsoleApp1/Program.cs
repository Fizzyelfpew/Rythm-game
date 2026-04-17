using Raylib_cs;
using System.Numerics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
// Rythm game
// Börja med att rita en blå backgrund
// Sedan loadar hunter, måln och crosshair

        // Start

        Raylib.InitWindow(1200, 800, "Skyrush");
        Raylib.SetTargetFPS(60);
        Texture2D bird = Raylib.LoadTexture(@"Bird.png");
        Texture2D cloud = Texture.Cloud();
        Hunter.texture = Texture.Hunter();
        Texture2D Jkeybind = Raylib.LoadTexture(@"J.png");
        Texture2D aim = Raylib.LoadTexture(@"aim.png");
        bool doingaction = false;
        int frametimelength = 0;
        int birdAnimation = 0;
        Rectangle birdspritedest = new(450, -40, 128, 128);
        Rectangle birdspriteDest1 = new(550, -40, 128,128);
        Rectangle birdspriteDest2 = new(650, -40, 128,128);
        Rectangle birdspriteDest3 = new(750, -40, 128,128);
        Rectangle aimspriteDest = new(450, 700, 64,64);
        Rectangle aimspriteDest1 = new(550, 700, 64,64);
        Rectangle aimspriteDest2 = new(650, 700, 64,64);
        Rectangle aimspriteDest3 = new(750, 700, 64,64);

        float sincelast = 0;
        float sincelast2 = 0;
        float sincelast3 = 0;
        float sincelast4 = 0;
        float bird1Cooldown = 10;
        float bird1Velocity = 8;
        float bird2Cooldown2 = 10;
        float bird2Velocity2 = 7;
        float bird3Cooldown3 = 10;
        float bird3Velocity3 = 6;
        float bird4Cooldown4 = 10;
        float bird4Velocity4 = 9;

        bool overlapping = Raylib.CheckCollisionRecs(birdspritedest, aimspriteDest);
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
            Raylib.DrawRectangleLinesEx(birdspritedest, 1, Color.Red);
            Raylib.DrawRectangleLinesEx(aimspriteDest, 1, Color.Red);
            (frametimelength, doingaction) = Frame_animation.Hunter_shooting_Miss(cloud, frametimelength, doingaction, overlapping, overlapping1, overlapping2, overlapping3); //Hunter missing
            birdAnimation = Frame_animation.Bird_animation(birdAnimation, bird, birdspritedest); //bird animation
            Frame_animation.Bird_animation(birdAnimation, bird, birdspriteDest1); //bird 2 animation
            Frame_animation.Bird_animation(birdAnimation, bird, birdspriteDest2);
            Frame_animation.Bird_animation(birdAnimation, bird, birdspriteDest3);
            Raylib.DrawText("Keybinds: Left = H Mid Left = J Mid Right = K Right = L", 800, 30, 15, Color.Black);
            Texture.Crosshair(aim, aimspriteDest); //crosshair
            Texture.Crosshair(aim, aimspriteDest1); 
            Texture.Crosshair(aim, aimspriteDest2); 
            Texture.Crosshair(aim, aimspriteDest3); 
            sincelast ++;
            sincelast2 ++;
            sincelast3 ++;
            sincelast4 ++;
            if(sincelast >= bird1Cooldown) //bird movement
            {
            birdspritedest.Y += bird1Velocity;
            sincelast = 0;
            }
            if(sincelast2 >= bird2Cooldown2)
            {
            birdspriteDest1.Y += bird2Velocity2;
            sincelast2 = 0;
            }
            if(sincelast3 >= bird3Cooldown3)
            {
            birdspriteDest2.Y += bird3Velocity3;
            sincelast3 = 0;
            }
            if(sincelast4 >= bird4Cooldown4)
            {
            birdspriteDest3.Y += bird4Velocity4;
            sincelast4 = 0;
            }
            
            Raylib.EndDrawing();

        }
        Raylib.CloseWindow();
