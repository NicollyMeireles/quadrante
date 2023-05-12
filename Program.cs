double x, y;
string local;


Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("QUADRANTE CARTESIANA");

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("ENTRE COM O PONTO DESEJADO");

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write("COORDENADA X:");
x = Convert.ToDouble(Console.ReadLine());

Console.Write("COORDENADA Y:");
y = Convert.ToDouble(Console.ReadLine());

if (x == 0 && y == 0) local = "a origem";
else if (x == 0) local = "o eixo das ordenadas";
else if (y == 0) local = "o eixo das abscissas";
else if (y > 0)
{
    if (x > 0)
        local = "o quadrante 1";
    else
        local = "o quadrante 2";
}
else
{
    if (x < 0)
        local = "o quadrante 3";
    else
        local = "o quadrante 4";
}

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"O ponto ({x}, {y}) fica n{local}.");

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Clique para inserir outros pontos");



