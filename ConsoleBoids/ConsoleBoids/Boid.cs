namespace ConsoleBoids;

public class Boid
{
    internal char Symbol { get; set; }
    private float X { get; set; }
    private float Y { get; set; }
    
    private float Dx { get; set; }
    private float Dy { get; set; }
    
    private float Speed { get; set; }

    public (float, float) CalculateNewPosition()
    {
        return (CalculateNewXPosition(), CalculateNewYPosition());
    }

    private float CalculateNewYPosition()
    {
        return this.Y + this.Dy * this.Speed;
    }

    private float CalculateNewXPosition()
    {
        return this.X + this.Dx * this.Speed;
    }
}