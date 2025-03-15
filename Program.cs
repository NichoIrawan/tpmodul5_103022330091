﻿class main
{
    static void Main(string[] args)
    {
        HaloGeneric a = new HaloGeneric();
        a.sapaUser<string>("Nicho");
        DataGeneric<string> b = new DataGeneric<string>("103022330091");
        b.printData();
    }
}

class DataGeneric<T>
{
    T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void printData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
    }
}

class HaloGeneric()
{
    public void sapaUser<T>(T user)
    {
        Console.WriteLine($"Halo User {user}");
    }
}
