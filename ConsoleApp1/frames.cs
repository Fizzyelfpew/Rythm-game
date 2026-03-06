
using Raylib_cs;
using System.Numerics;
public class Frame_animation()
{
    public static Texture2D Hunter_shooting()
    {
        Texture2D cloud = Texture.Cloud();
        Rectangle hunterrectangle = new(100, 700, Hunter.texture.Dimensions);
        Rectangle cloudRectangle = new(1000, 225, cloud.Dimensions);
        bool overlapping = Raylib.CheckCollisionRecs(hunterrectangle, cloudRectangle);
        if (Raylib.IsKeyPressed(KeyboardKey.H) && overlapping == false)
        {
                Rectangle hunterspritesource2 = new(128, 128, 128, 128);
                Rectangle hunterspriteDest2 = new(100, 760, 512, 512);
                Vector2 hunterOrigin = new Vector2(hunterspriteDest2.Width / 2, hunterspriteDest2.Height / 2);
                float hunterrotation = 0;
                Raylib.DrawTexturePro(Hunter.texture, hunterspritesource2, hunterspriteDest2, hunterOrigin, hunterrotation, Color.White);
        }
        return Hunter.texture;
        // if(Raylib.IsKeyPressed(KeyboardKey.H))
        // {
        // if (Hunter_animationlength <= 20)
        // {
        // Rectangle hunterspritesource2 = new(128,0, 128,128);
        // Rectangle hunterspriteDest2 = new(100, 800, 512,512);
        // Vector2 hunterOrigin = new Vector2(hunterspriteDest2.Width/2,hunterspriteDest2.Height/2);
        // float hunterrotation = 0;
        // Raylib.DrawTexturePro(hunter, hunterspritesource2, hunterspriteDest2, hunterOrigin, hunterrotation, Color.White);
        // Hunter_animationlength++;  
        // }
        // else if(Hunter_animationlength == 20)
        // {
        //     Texture.Huntersize();
        // }
        // }
        // if (Raylib.IsKeyPressed(KeyboardKey.H)&& overlapping == true)
        // {
        //     // Raylib.DrawTexturePro()
        // } 
    }

}


