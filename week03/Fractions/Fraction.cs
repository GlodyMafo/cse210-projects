using System;
using System.Diagnostics;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top=top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top=top;
        _bottom=bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public int setTop(int top)
    {
        return top = _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public int SetBottom(int bottom)
    {
        return bottom = _bottom;
    }

    public string GetFractionString()
    {
  
    string result = $"{_top}/{_bottom}";
    return result;
  
    }

    public double GetDecimalValue()
    {
        double result = _top / _bottom;

        return result;
    }
}