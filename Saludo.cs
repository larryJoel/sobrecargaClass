using System.Security.Cryptography.X509Certificates;
class Saludo{
    public void Mostrar(string texto){
        Console.WriteLine(texto);
    }

    public void Mostrar(string texto, int columna, int fila){
        Console.SetCursorPosition(columna, fila);
        Console.WriteLine(texto);
    }
    public void Mostrar(string texto, int columna, int fila, ConsoleColor colorLetra){
        Console.ForegroundColor = colorLetra;
        Mostrar(texto, columna, fila);
    }

    public void Mostrar(string texto, int columna, int fila, ConsoleColor colorLetra, ConsoleColor colorFondo){
        Console.BackgroundColor = colorFondo;
        Mostrar(texto, columna, fila, colorLetra);
    }
}