class main
{
    static void Main(string[] args)
    {
        HaloGeneric a = new HaloGeneric();
        a.sapaUser<string>("Nicho");
    }
}

class HaloGeneric()
{
    public void sapaUser<T>(T user)
    {
        Console.WriteLine($"Halo User {user}");
    }
}
