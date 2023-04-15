
void arreglos()
{
    int n = 0;
    bool check = false;

    do
    {
        Console.Write("Ingresa el número de estudiantes: ");
        check = int.TryParse(Console.ReadLine(), out n);
    } while (n == 0 || check == false);

    string[] nombre = new string[n];
    int[] notas = new int[n];

    for (int i = 0; i < n; i++)
    {
        Console.Write($"Ingresa el nombre del estudiante numero {i + 1}: ");
        nombre[i] = Console.ReadLine();
    }

    for (int i = 0; i < n; i++)
    {
        Console.Write($"Ingresa la calificación del estudiante numero {i + 1}: ");
        int.TryParse(Console.ReadLine(), out notas[i]);
    }

    int nummayor = notas.Max();
    int nummenor = notas.Min();
    int indmayor = 0, indmenor = 0;

    foreach (int nota in notas)
    {
        if (nota > notas[indmayor])
        {
            indmayor = Array.IndexOf(notas, nota);
        }
    }

    foreach (int nota in notas)
    {
        if (nota < notas[indmenor])
        {
            indmenor = Array.IndexOf(notas, nota);
        }
    }

    Console.WriteLine($"La calificación más alta es {nummayor}, que pertenece a {nombre[indmayor]}.");
    Console.WriteLine($"La calificación más baja es {nummenor}, que pertenece a {nombre[indmenor]}.");
}

arreglos();
