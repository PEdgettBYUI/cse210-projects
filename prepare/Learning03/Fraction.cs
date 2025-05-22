class Fraction
{
    private int _top;
    private int _bottom;

    // Constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNum)
    {
        _top = wholeNum;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void printFraction()
    {
        Console.WriteLine($"Top {_top}");
        Console.WriteLine($"Bottom {_bottom}");
    }

    // Getters
    public int GetTopNum()
    {
        return _top;
    }

    public int GetBottomNum()
    {
        return _bottom;
    }

    // Setters
    public void SetTopNum(int topNum)
    {
        _top = topNum;
    }
    public void SetBottomNum(int bottomNum)
    {
        _bottom = bottomNum;
    }

    // Return in Format
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

    public string GetFractionString()
    {
        string writFract = $"{_top}/{_bottom}";
        return writFract;
    }

}