using Raylib_cs;
using System.Numerics;
public class Texture()
{
    public static Texture2D Cloud()
    {
         Texture2D cloud = Raylib.LoadTexture(@"nuvem.png");
        return cloud;
    }
    public static Texture2D Cloudsize1()
    {
        Texture2D cloud = Texture.Cloud();
        Rectangle cloudspritesource1 = new(0,0, 32,32);
        Rectangle cloudspriteDest = new(1000, 425, 256,256);
        Vector2 cloudOrigin = new Vector2(cloudspriteDest.Width/2,cloudspriteDest.Height/2);
        float cloudrotation = 0;
        Raylib.DrawTexturePro(cloud, cloudspritesource1, cloudspriteDest, cloudOrigin, cloudrotation, Color.White);
        return cloud;

    }
    public static Texture2D Cloudsize2()
    {
        Texture2D cloud = Texture.Cloud();
        Rectangle cloudspritesource1 = new(0,0, 32,32);
        Rectangle cloudspriteDest2 = new(200, 100, 256,256);
        Vector2 cloudOrigin = new Vector2(cloudspriteDest2.Width/2,cloudspriteDest2.Height/2);
        float cloudrotation = 0;
        Raylib.DrawTexturePro(cloud, cloudspritesource1, cloudspriteDest2, cloudOrigin, cloudrotation, Color.White);

        return cloud;

    }
    public static Texture2D Hunter()
    {
         Texture2D hunter = Raylib.LoadTexture(@"Hunter.png");
        return hunter;
    }
        public static Texture2D Huntersize()
    {
        Texture2D hunter = Texture.Hunter();
        Rectangle hunterspritesource1 = new(0,0, 128,128);
        Rectangle hunterspriteDest2 = new(100, 760, 512,512);
        Vector2 hunterOrigin = new Vector2(hunterspriteDest2.Width/2,hunterspriteDest2.Height/2);
        float hunterrotation = 0;
        Raylib.DrawTexturePro(hunter, hunterspritesource1, hunterspriteDest2, hunterOrigin, hunterrotation, Color.White);

        return hunter;
    }
}