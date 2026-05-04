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
        Rectangle birdspritedest = new(450, -100, 128, 128);
        Rectangle birdspriteDest1 = new(550, -100, 128,128);
        Rectangle birdspriteDest2 = new(650, -100, 128,128);
        Rectangle birdspriteDest3 = new(750, -100, 128,128);
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
        float Miss = 0;
        while (!Raylib.WindowShouldClose())
        {

        // Input
        //Drawing
        if(overlapping == false || overlapping1 == false||overlapping2 == false || overlapping3 == false )
        {
        Miss += 0.00114f;
        }
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.SkyBlue);
            Texture.Cloud1size(cloud); //Cloud number 1
            Texture.Cloud2size(cloud); //Cloud number 2
            (frametimelength, doingaction) = Frame_animation.Hunter_shooting_Miss_animation(cloud, frametimelength, doingaction, overlapping, overlapping1, overlapping2, overlapping3); //Hunter missing
            birdAnimation = Frame_animation.Bird_flying_animation(birdAnimation, bird, birdspritedest); //Bird flying animation
            Frame_animation.Bird_flying_animation(birdAnimation, bird, birdspriteDest1); //Bird 2 flying animation
            Frame_animation.Bird_flying_animation(birdAnimation, bird, birdspriteDest2); //Bird 3 flying animation
            Frame_animation.Bird_flying_animation(birdAnimation, bird, birdspriteDest3); //Bird 4 flying animation
            Raylib.DrawText("Keybinds: Left = H Mid Left = J Mid Right = K Right = L", 800, 30, 15, Color.Black); //Keybinds for each control
            Raylib.DrawText($"Miss counter: {(int)Miss}", 50, 200, 30, Color.Black);
            Texture.Crosshair(aim, aimspriteDest); //crosshair
            Texture.Crosshair(aim, aimspriteDest1); 
            Texture.Crosshair(aim, aimspriteDest2); 
            Texture.Crosshair(aim, aimspriteDest3); 
            if(birdspritedest.Y >= 850)
            {
                birdspritedest.Y = -100;
            }
            if(birdspriteDest1.Y >= 850)
            {
                birdspriteDest1.Y = -100;
            }
            if(birdspriteDest2.Y >= 850)
            {
                birdspriteDest2.Y = -100;
            }
            if(birdspriteDest3.Y >= 850)
            {
                birdspriteDest3.Y = -100;
            }
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

        // Improvements and fixes fixes
        // First fix, i need to align hitboxes with their corresponding sprites
        // Fix overlapping always being false and not working
        // Add hunter hitting animation