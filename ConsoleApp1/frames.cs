
using Raylib_cs;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
public class Frame_animation()
{


        public static (int, bool) Hunter_shooting_Miss(Texture2D cloud, int frametimelength, bool doingaction, bool overlapping, bool overlapping1, bool overlapping2, bool overlapping3)
        {      
                
                if (Raylib.IsKeyPressed(KeyboardKey.H) && overlapping == false  || doingaction == true)
                {
                        doingaction = true;
                        Rectangle hunterspritesource2 = new(128, 128, 128, 128);
                        Rectangle hunterspriteDest2 = new(100, 760, 512, 512);
                        Vector2 hunterOrigin = new Vector2(hunterspriteDest2.Width / 2, hunterspriteDest2.Height / 2);
                        float hunterrotation = 0;
                        Raylib.DrawTexturePro(Hunter.texture, hunterspritesource2, hunterspriteDest2, hunterOrigin, hunterrotation, Color.White);
                        if (frametimelength >= 20)
                        {
                                frametimelength = 0;
                                doingaction = false;
                        }
                        else
                        {
                                frametimelength++;
                        }
                }
                if (Raylib.IsKeyPressed(KeyboardKey.J) && overlapping1 == false  || doingaction == true)
                {
                        doingaction = true;
                        Rectangle hunterspritesource2 = new(128, 128, 128, 128);
                        Rectangle hunterspriteDest2 = new(100, 760, 512, 512);
                        Vector2 hunterOrigin = new Vector2(hunterspriteDest2.Width / 2, hunterspriteDest2.Height / 2);
                        float hunterrotation = 0;
                        Raylib.DrawTexturePro(Hunter.texture, hunterspritesource2, hunterspriteDest2, hunterOrigin, hunterrotation, Color.White);
                }
                if (Raylib.IsKeyPressed(KeyboardKey.K) && overlapping2 == false  || doingaction == true)
                {
                        doingaction = true;
                        Rectangle hunterspritesource2 = new(128, 128, 128, 128);
                        Rectangle hunterspriteDest2 = new(100, 760, 512, 512);
                        Vector2 hunterOrigin = new Vector2(hunterspriteDest2.Width / 2, hunterspriteDest2.Height / 2);
                        float hunterrotation = 0;
                        Raylib.DrawTexturePro(Hunter.texture, hunterspritesource2, hunterspriteDest2, hunterOrigin, hunterrotation, Color.White);
                }
                if (Raylib.IsKeyPressed(KeyboardKey.L) && overlapping3 == false  || doingaction == true)
                {
                        doingaction = true;
                        Rectangle hunterspritesource2 = new(128, 128, 128, 128);
                        Rectangle hunterspriteDest2 = new(100, 760, 512, 512);
                        Vector2 hunterOrigin = new Vector2(hunterspriteDest2.Width / 2, hunterspriteDest2.Height / 2);
                        float hunterrotation = 0;
                        Raylib.DrawTexturePro(Hunter.texture, hunterspritesource2, hunterspriteDest2, hunterOrigin, hunterrotation, Color.White);
                }
                else
                {
                        Texture.Huntersize(Hunter.texture);
                }
                return (frametimelength, doingaction);
        }


        public static int Bird_animation(int birdAnimation, Texture2D bird, Rectangle birdspriteDest)
        {
        Rectangle birdspritesource1 = new(0,0, 64,64);
        Rectangle birdspritesource2 = new(64,0, 64,64);
        Rectangle birdspritesource3 = new(0,64, 64,64);
        Vector2 birdOrigin = new Vector2(birdspriteDest.Width/2,birdspriteDest.Height/2);
        float birdrotation = 180;
        if (birdAnimation == 0)
        {
            birdAnimation = 60;
            Raylib.DrawTexturePro(bird, birdspritesource1, birdspriteDest, birdOrigin, birdrotation, Color.White);
        }
        else if (birdAnimation >= 50)
        {
            Raylib.DrawTexturePro(bird, birdspritesource1, birdspriteDest, birdOrigin, birdrotation, Color.White);
            birdAnimation --;
        }
        else if (birdAnimation >= 40 && birdAnimation <= 50)
        {
            Raylib.DrawTexturePro(bird, birdspritesource2, birdspriteDest, birdOrigin, birdrotation, Color.White);
            birdAnimation--;
        }
        else if (birdAnimation >= 30 && birdAnimation <= 40)
        {
            Raylib.DrawTexturePro(bird, birdspritesource3, birdspriteDest, birdOrigin, birdrotation, Color.White);
            birdAnimation--;
        }
        else if (birdAnimation >= 20 && birdAnimation <= 30)
        {
            Raylib.DrawTexturePro(bird, birdspritesource3, birdspriteDest, birdOrigin, birdrotation, Color.White);
            birdAnimation--;
        }
        else if (birdAnimation >= 10 && birdAnimation <= 20)
        {
            Raylib.DrawTexturePro(bird, birdspritesource2, birdspriteDest, birdOrigin, birdrotation, Color.White);
            birdAnimation--;
        }
        else if (birdAnimation >= 1 && birdAnimation <= 10)
        {
            Raylib.DrawTexturePro(bird, birdspritesource1, birdspriteDest, birdOrigin, birdrotation, Color.White);
            birdAnimation--;
        }

        return birdAnimation;
    }
}




