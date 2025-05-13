// Classes cannot be defined in Main; must be external to the program
// Private means the variable cannot be accessed outside of the class
// Public means that it can be accessed from outside of the class
// i.e. you can use Circle.SetRadius() & Circle.GetRadius(), but you can't access "private double _radius;" directly

class Cylinder
{
    private Circle _circle;

    private double _height;

    public void SetHeight(double height)
    {
        _height = height;
    }

    public void SetCircle(Circle circle)
    {
        _circle = circle;
    }

    public double GetVolume()
    {
        return Math.PI * _circle.GetRadius() * _circle.GetRadius()  * _height;
    }
}