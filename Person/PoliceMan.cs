class PoliceMan : Person
{
    private string _weapons;

    public PoliceMan(string firstName, string lastName, int age, string weapons)
    : base(firstName, lastName, age)    // : base() calls a constructor from the Base/Parent class, in this case, Person
    {
        _weapons = weapons;
    }

    public string GetPolicemanInformation()
    {
        // string temp = GetPersonInformation() + $", Uses: {_weapons}";
        // return temp;

        return $"Weapons: {_weapons} :: {GetPersonInformation()}";
    }
}