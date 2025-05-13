class Circle
{
    private double _radius; // attribute

    public void SetRadius(double radius)
    {
        int bob = 9;    // This is a local variable, not an attribute of the class
        if(radius <0)
        {
            Console.WriteLine("Error");
            return;
        }
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}