using System;

ColorRGB Red = new ColorRGB(255,0,0);
ColorRGB White = new ColorRGB(255,255,255);
ColorRGB Custom = new ColorRGB(100,150,200);
Console.WriteLine($"빨강 - R: {Red.R}, G: {Red.G}, B: {Red.B} -> 밝기: {Red.GetBrightness()}");
Console.WriteLine($"흰색 - R: {White.R}, G: {White.G}, B: {White.B} -> 밝기: {White.GetBrightness()}");
Console.WriteLine($"커스텀 - R: {Custom.R}, G: {Custom.G}, B: {Custom.B} -> 밝기: {Custom.GetBrightness()}");
struct ColorRGB
{
    public int R;
    public int G;
    public int B;
    public ColorRGB(int r, int g, int b)
    {
        R = r;
        G = g;
        B = b;
    }
    public int GetBrightness()
    {
        return (R + G + B) / 3;
    }
}
