namespace WinFormsApp69;

public static class Program
{
    [STAThread]
    public static void Main()
    {
        Controller verwalter = new Controller();

        verwalter.Run();
    }
}