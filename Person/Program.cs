class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bob");

        Person myDude = new Person("Gary", "Bob", 53);
        Console.WriteLine(myDude.GetPersonInformation());

        PoliceMan myPig = new PoliceMan("Bullet", "Smelly", 50, ".22 Pistol");
        Console.WriteLine(myPig.GetPolicemanInformation());

        Doctor myDoc = new Doctor("Bob", "Payne", 35, "Scalpel");
        Console.WriteLine(myDoc.GetDoctorInformation());

    }
}
