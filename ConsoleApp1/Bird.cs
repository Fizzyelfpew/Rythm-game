
using Raylib_cs;
using System.Numerics;
class Bird
{
    public static void Birdsize(Texture2D bird)
    {
        Rectangle birdspritesource1 = new(0,0, 128,128);
        Rectangle birdspriteDest2 = new(100, 760, 512,512);
        Vector2 birdOrigin = new Vector2(birdspriteDest2.Width/2,birdspriteDest2.Height/2);
        float birdrotation = 0;
        Raylib.DrawTexturePro(bird, birdspritesource1, birdspriteDest2, birdOrigin, birdrotation, Color.White);

    }
}