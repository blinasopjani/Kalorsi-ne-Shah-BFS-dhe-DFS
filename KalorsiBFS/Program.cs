using System;
using System.Collections.Generic;

class LevizjetEKaloresit
{
    private static readonly int[] dx = { -2, -2, -1, 1, 2, 2, 1, -1 };
    private static readonly int[] dy = { -1, 1, 2, 2, 1, -1, -2, -2 };

    private static bool EshteNeTabele(int x, int y, int n)
    {
        return x >= 0 && x < n && y >= 0 && y < n;
    }

    public static void GjejRugenMeTeShkurtër(int fillimiX, int fillimiY, int destinacioniX, int destinacioniY, int n)
    {
        Queue<(int, int, List<(int, int)>)> radha = new Queue<(int, int, List<(int, int)>)>();
        bool[,] vizituar = new bool[n, n];

        radha.Enqueue((fillimiX, fillimiY, new List<(int, int)> { (fillimiX, fillimiY) }));
        vizituar[fillimiX, fillimiY] = true;

        while (radha.Count > 0)
        {
            var (x, y, rruga) = radha.Dequeue();

            if (x == destinacioniX && y == destinacioniY)
            {
                Console.WriteLine($"Levizje: {rruga.Count - 1}");
                Console.WriteLine("Rruga: " + string.Join(" -> ", rruga.ConvertAll(p => $"({p.Item1},{p.Item2})")));
                return;
            }

            for (int i = 0; i < 8; i++)
            {
                int newX = x + dx[i];
                int newY = y + dy[i];

                if (EshteNeTabele(newX, newY, n) && !vizituar[newX, newY])
                {
                    vizituar[newX, newY] = true;
                    var rrugaRe = new List<(int, int)>(rruga) { (newX, newY) };
                    radha.Enqueue((newX, newY, rrugaRe));
                }
            }
        }

        Console.WriteLine("Nuk u gjet rruga.");
    }

    static void Main()
    {
        int n = 8; // Madhesia e tabeles se shahut (8x8)

        Console.Write("Shkruaj poziten fillestare (X): ");
        int fillimiX = int.Parse(Console.ReadLine());

        Console.Write("Shkruaj poziten fillestare (Y): ");
        int fillimiY = int.Parse(Console.ReadLine());

        Console.Write("Shkruaj poziten e destinacionit (X): ");
        int destinacioniX = int.Parse(Console.ReadLine());

        Console.Write("Shkruaj poziten e destinacionit (Y): ");
        int destinacioniY = int.Parse(Console.ReadLine());

        GjejRugenMeTeShkurtër(fillimiX, fillimiY, destinacioniX, destinacioniY, n);
    }
}
