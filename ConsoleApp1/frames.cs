using Raylib_cs;

public class Frames()
{
    public Texture2D Hunter_shooting()
    {
        Rectangle hunterrectangle = new(100,700, hunter.Dimensions);
        Rectangle cloudRectangle = new(1000, 225, cloud.Dimensions);
        
        bool overlapping = Raylib.CheckCollisionRecs(hunterrectangle, cloudRectangle);
            if (Raylib.IsKeyPressed(KeyboardKey.H)&& overlapping == true)
            {
                // Raylib.DrawTexturePro()
            } 
            if(Raylib.IsKeyPressed(KeyboardKey.H) && overlapping == false)
            {
                
            } 
        return Texture.Hunter();
    }

}
            
            
            