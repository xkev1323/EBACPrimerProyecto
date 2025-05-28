using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class EjerciciosEstructuras : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Ejercicio 1: Crear una lista de enteros y llenarla con números aleatorios
        List<int> numeros = NumerosAleatorios(5, 10, 20);
        Debug.Log("Lista de números aleatorios: " + string.Join(", ", numeros));
        
        Debug.Log("");

        // Ejercicio 2: Ordenar un arreglo de enteros de mayor a menor y convertirlo a un nuevo arreglo
        int[] original = { 5, 3, 8, 1, 4 };
        int[] ordenado = OrdenarDescendente(original);
        Debug.Log("Arreglo original: " + string.Join(", ", original));
        Debug.Log("Arreglo ordenado de mayor a menor: " + string.Join(", ", ordenado));

        Debug.Log("");

        // Ejercicio 3: Usar HashSet para eliminar duplicados de una lista de enteros
        // Ejemplo con enteros
        List<int> listaConDuplicados = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
        HashSet<int> sinDuplicados = EliminarDuplicados(listaConDuplicados);
        Debug.Log("Lista original con duplicados: " + string.Join(", ", listaConDuplicados));
        Debug.Log("Lista sin duplicados (HashSet): " + string.Join(", ", sinDuplicados));

        Debug.Log("");

        // Ejemplo con strings
        List<string> listaConDuplicadosStrings = new List<string> { "a", "b", "b", "c", "d", "d" };
        HashSet<string> sinDuplicadosStrings = EliminarDuplicadosLinq(listaConDuplicadosStrings);
        Debug.Log("Lista original de strings con duplicados: " + string.Join(", ", listaConDuplicadosStrings));
        Debug.Log("Lista de strings sin duplicados (HashSet): " + string.Join(", ", sinDuplicadosStrings));

        Debug.Log("");

        // Ejercicio 4: Imprimir los contenidos de una pila de strings y vaciarla llenando una cola
        Stack<string> miPila = new Stack<string>();
        miPila.Push("Elemento 1");
        miPila.Push("Elemento 2");
        miPila.Push("Elemento 3");

        ProcesarPilaYCola(miPila);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Crea una lista de enteros y llena la lista con números aleatorios 
    public List<int> NumerosAleatorios(int tamaño, int rangoInferior, int rangoSuperior)
    {
        List<int> numeros = new List<int>();
        for (int i = 0; i < tamaño; i++)
        {
            int numeroAleatorio = Random.Range(rangoInferior, rangoSuperior);
            numeros.Add(numeroAleatorio);
        }
        return numeros;
    }

    // Ordena el arreglo de mayor a menor y lo convierte a un nuevo arreglo
    public int[] OrdenarDescendente(int[] arreglo)
    {
        int[] arregloOrdenado = arreglo.OrderByDescending(num => num).ToArray();
        return arregloOrdenado;
    }

    // Usando HashSet directamente (generico)
    public HashSet<T> EliminarDuplicados<T>(List<T> lista)
    {
        HashSet<T> conjunto = new HashSet<T>(lista);
        return conjunto;
    }

    // Usando el metodo Distinct() de LINQ para eliminar duplicados.
    public HashSet<T> EliminarDuplicadosLinq<T>(List<T> lista)
    {
        HashSet<T> conjunto = lista.Distinct().ToHashSet();
        return conjunto;
    }

    // Imprimir sus contenidos de una pila de strings
    public void ProcesarPilaYCola(Stack<string> pila)
    {
        Debug.Log("Contenido de la pila (Stack):");
        Stack<string> copiaPila = new Stack<string>(pila);

        //Imprimir y vaciar la pila, llenando la cola
        Queue<string> cola = new Queue<string>();
        while (copiaPila.Count > 0)
        {
            string elemento = copiaPila.Peek(); // Ver el elemento en la cima
            Debug.Log("Peek (Stack): " + elemento);
            cola.Enqueue(elemento);             // Encolar el elemento
            Debug.Log("Pop (Stack): " + copiaPila.Pop()); // Sacar el elemento de la pila
        }

        Debug.Log("Contenido de la cola (Queue):");
        while (cola.Count > 0)
        {
            string elemento = cola.Peek(); // Ver el elemento al frente
            Debug.Log("Peek (Queue): " + elemento);
            Debug.Log("Dequeue (Queue): " + cola.Dequeue()); // Sacar el elemento de la cola
        }
    }
}
