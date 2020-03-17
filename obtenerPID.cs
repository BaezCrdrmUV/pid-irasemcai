using system;
using System.Diagnostics;

namespace ObtenerPID
{
    public static class Program{
        Process proceso = Process.GetCurrentProcess();        
        Console.WriteLine("started proceso ID: " + proceso.Id);
        Console.ReadLine();
    }
}