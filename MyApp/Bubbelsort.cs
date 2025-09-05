using System;

public class BubbleSort
{
    public static void Main(string[] args)
    {
       int[] zahlen = { 10, 3, 18, 1, 99 };

        Console.WriteLine("Unsortierte Zahlen:");
        DruckeArray(zahlen);

        Sortiere(zahlen);

        Console.WriteLine("\nSortierte Zahlen:");
        DruckeArray(zahlen);
    }

    // Einfache Bubble-Sort-Implementierung (aufsteigend):qa!
    
    public static void Sortiere(int[] arr)
    {
        if (arr == null || arr.Length < 2) return;

        for (int i = 0; i < arr.Length - 1; i++) // Inner Schleife für den Sortiervorgang
        {
            bool getauscht = false;
            // Die innere Schleife durchläuft das Array
            // Nach jedem Durchlauf ist das größte Element am Ende,
            // daher nur bis Length - i - 1 vergleichen.
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    getauscht = true;
                }
            }

            // Kleine Optimierung: wenn nichts getauscht wurde, ist schon sortiert.
            if (!getauscht) break;
        }
    }

    public static void DruckeArray(int[] arr)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(string.Join(", ", arr));
        Console.ResetColor(); // Wichtig: Farbe zurücksetzen
    }
}
