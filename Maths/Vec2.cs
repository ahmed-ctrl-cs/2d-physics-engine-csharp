using System.ComponentModel.DataAnnotations;

public class vec2
{
    public float x { get; set; }
    public float y { get; set; }
    //Vector addition
    public vec2 add(vec2 b)
    {
        float x = this.x + b.x;
        float y = this.y + b.y;
        vec2 result = new vec2();
        result.x = x;
        result.y = y;
        return result;
    }
    //Vector subtraction
    public vec2 sub(vec2 b)
    {
        float x = this.x - b.x;
        float y = this.y - b.y;
        vec2 result = new vec2();
        result.x = x;
        result.y = y;
        return result;
    }
    //Vector scaling
    public vec2 scale(float scalar)
    {
        float x = this.x * scalar;
        float y = this.y * scalar;
        vec2 result = new vec2();
        result.x = x;
        result.y = y;
        return result;
    }
    //Vector magnitude
    public float mag()
    {
        return MathF.Sqrt((this.x * this.x) + (this.y * this.y));
    }
    //Vector normalization
    public vec2 norm()
    {
        if (this.x == 0 && this.y == 0)
        {
            return new vec2();
        }
        float magnitude = this.mag();
        float x = this.x / magnitude;
        float y = this.y / magnitude;
        vec2 result = new vec2();
        result.x = x;
        result.y = y;
        return result;
    }
    //Vector dot product
    public float dot(vec2 b)
    {
        return (this.x * b.x) + (this.y * b.y);
    }
}