class Person
{
    private string _lastName;
    private string _firstName;
    private int _age;

    public Person()
    {
        _lastName = "";
        _firstName = "";
        _age = 0;
    }

    public Person(string lastName, string firstName, int age)
    {
        _lastName = lastName;
        _firstName = firstName;
        _age = age;
    }


    // You can define access-types as either public, private, or Protected.
    // - Public means it can be accessed from anywhere
    // - Private means it can't be accessed directly, and you'll need setters-&-getters to interact
    // - Protected means that only the direct-child class of the function's parent can access it.
    public string GetPersonInformation()
    {
        return $"{_firstName} {_lastName}, Age: {_age}";
    }
}