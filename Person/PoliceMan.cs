class PoliceMan : Person
{
    private string _weapons;

    public PoliceMan(string firstName, string lastName, int age, string weapons)
    : base(firstName, lastName, age)
    {
        _weapons = weapons;
    }

        public string GetPolicemanInformation()
    {
        string temp = GetPersonInformation() + $", Uses: {_weapons}";


        return temp;
    }

}