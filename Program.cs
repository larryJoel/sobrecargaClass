class Proggram{
    static void Main(string[] args){
        var s = new Saludo();
        s.Mostrar("Hola mundo");
        s.Mostrar("Hola Mundo", 20,5);
        s.Mostrar("Hola Mundo", 20,7,ConsoleColor.Red);
        s.Mostrar("Hola Mundo",20,9,ConsoleColor.Red, ConsoleColor.Yellow);
    }
}