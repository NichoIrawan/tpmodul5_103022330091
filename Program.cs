class main
{
    static void Main(string[] args)
    {
        DataGeneric<string> a = new DataGeneric<string>("103022330091");
        a.printData();
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