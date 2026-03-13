
using Raylib_cs;
using System.Numerics;
public class Frame_animation()
{

        

        public static (int, bool) Hunter_shooting_Miss(Texture2D cloud, int frametimelength, bool doingaction)
        {
                Rectangle hunterrectangle = new(100, 700, Hunter.texture.Dimensions);
                Rectangle cloudRectangle = new(1000, 225, cloud.Dimensions);
                bool overlapping = Raylib.CheckCollisionRecs(hunterrectangle, cloudRectangle);
                
                

                if ((Raylib.IsKeyPressed(KeyboardKey.H) || Raylib.IsKeyPressed(KeyboardKey.J) || Raylib.IsKeyPressed(KeyboardKey.K) || Raylib.IsKeyPressed(KeyboardKey.L) && overlapping == false) ==true || doingaction == true)
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
                else
                {
                        Texture.Huntersize(Hunter.texture);
                }

                return (frametimelength, doingaction);
        }
}




