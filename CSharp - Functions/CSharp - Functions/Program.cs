// See https://aka.ms/new-console-template for more information
Console.WriteLine("CSharp Functions");

int[] lista = { 2, 6, 7, 5, 9 };

stampaArray(lista);
stampaArray(arrayElevatoAlQuadrato(lista));
stampaArray(lista);

int sum = sommaElementiArray(lista);

Console.WriteLine("La somma di tutti gli elementi è: " + sum);

int sumAlQuadrato = sommaElementiArray(elevaArrayAlQuadrato(lista));

Console.WriteLine("La somma di tutti i numeri elevati al quadrato è: " + sumAlQuadrato);


// FUNZIONI //
void stampaArray(int[] array);
{
    Console.Write("[ ");

    for (int i = 0; i < lista.Length - 1; i++)
    {
        Console.Write(lista[i] + ", ");
    }
    Console.WriteLine(lista[lista.Length - 1] + "]");
}

int quadrato(int numero)
{
    int risultato;
    risultato = numero * numero;
    return risultato;
}

int[] elevaArrayAlQuadrato(int[] lista)
{
    int[] copiaLista = (int[])lista.Clone();

    for (int i = 0; i < lista.Length; i++)
    {
        copiaLista[i] = quadrato(copiaLista[i]);
    }
    return copiaLista;
}

int sommaElementiArray(int[] lista);
{
    int[] copiaLista = (int[])lista.Clone();
    int somma = 0;

    for (int i = 0; i < lista.Length; i++)
    {
        somma += copiaLista[i];
    }
    return somma;
}
