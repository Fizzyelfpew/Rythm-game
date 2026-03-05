using Raylib_cs;
using System.Numerics;
public class Texture()
{
    public static Texture2D cloud()
    {
         Texture2D cloud = Raylib.LoadTexture(@"nuvem.png");
        return cloud;
    }
}