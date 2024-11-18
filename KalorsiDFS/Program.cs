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

    
    public static bool DFS(int x, int y, int destinacioniX, int destinacioniY, int n, bool[,] vizituar, List<(int, int)> rruga)
    {
        
        if (x == destinacioniX && y == destinacioniY)
        {
            rruga.Add((x, y));
            return true;
        }

        
        vizituar[x, y] = true;
        rruga.Add((x, y));

        
        for (int i = 0; i < 8; i++)
        {
            int newX = x + dx[i];
            int newY = y + dy[i];

            
            if (EshteNeTabele(newX, newY, n) && !vizituar[newX, newY])
            {
                if (DFS(newX, newY, destinacioniX, destinacioniY, n, vizituar, rruga))
                {
                    return true;
                }
            }
        }

        
        rruga.RemoveAt(rruga.Count - 1);
        return false;
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

        
        bool[,] vizituar = new bool[n, n];

        
        List<(int, int)> rruga = new List<(int, int)>();

        
        if (DFS(fillimiX, fillimiY, destinacioniX, destinacioniY, n, vizituar, rruga))
        {
            Console.WriteLine("Rruga e gjetur: ");
            Console.WriteLine($"Levizje: {rruga.Count - 1}");
            Console.WriteLine("Rruga: " + string.Join(" -> ", rruga.ConvertAll(p => $"({p.Item1},{p.Item2})")));
            
        }
        else
        {
            Console.WriteLine("Nuk u gjet rruga.");
        }
    }
}
