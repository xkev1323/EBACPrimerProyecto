using UnityEngine;

public class EjerciciosDeCiclosYArreglos : MonoBehaviour
{

    // Crea dos arreglos unidimensionales de numeros enteros...
    [Header("Ejercicio 1 / Sumas de dos arreglos")]
    public int size = 10;
    int[] arr1;
    int[] arr2;
    int[] arr3;

    [Header("Ejercicio 2 / Concatenar un arreglo de palabras a un string")]
    public string[] palabras = new string[5] { "Hola", "Mundo", "Soy", "Un", "Arreglo" };

    [Header("Ejercicio 3 / Crear un arreglo bidimensional y multiplicar por un arreglo unidimensional de enteros")]
    public int renglones = 2;
    public int columnas = 3;
    int[,] arr2D;
    int[] arr1D;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Ejercicio1();
        Ejercicio2();
        Ejercicio3();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Llenar los arreglos usando un ciclo y la funcion random.range con numeros enteros y sumarlos los arreglos...
    void Ejercicio1()
    {
        Debug.LogWarning("Ejercicio 1 / Sumas de dos arreglos");

        // Tamaño de los arreglos
        arr1 = new int[size];
        arr2 = new int[size];
        arr3 = new int[size];

        // Llenar los arreglos
        for (int i = 0; i < size; i++)
        {
            arr1[i] = Random.Range(0, 100);
            arr2[i] = Random.Range(0, 100);
        }

        // Sumar los arreglos
        for (int i = 0; i < size; i++)
        {
            arr3[i] = arr1[i] + arr2[i];
        }

        // Imprimir los arreglos
        Debug.Log("Arreglo 1: " + "[" + string.Join(", ", arr1) + "]");
        Debug.Log("Arreglo 2: " + "[" + string.Join(", ", arr2) + "]");
        Debug.Log("Operaciones de suma entre los arreglos: ");
        for (int i = 0; i < size; i++)
        {
            Debug.Log($"Arreglo 1: [{arr1[i]}] + Arreglo 2: [{arr2[i]}] = Arreglo 3: [{arr3[i]}]");
        }
        Debug.Log("Arreglo 3: " + "[" + string.Join(", ", arr3) + "]");
    }

    // Crea un arreglo de palabras y concatenar el arreglo a un string...
    void Ejercicio2()
    {
        // La variable para la oracion
        string oracion = "";

        // Concatenar el arreglo de palabras a la oracion
        foreach (string palabra in palabras)
        {
            oracion += palabra + " ";
        }

        // Imprimir la oracion
        Debug.LogWarning("Ejercicio 2 / Concatenar un arreglo de palabras a un string");
        Debug.Log("Arreglo de palabras: " + "[" + string.Join(", ", palabras) + "]");
        Debug.Log($"Las Palabras en una oracion: {oracion}");
    }

    // Crear un arreglo bidimensional y multiplicar por un arreglo unidimensional de enteros...
    void Ejercicio3()
    {
        Debug.LogWarning("Ejercicio 3 / Multiplicación de matriz por vector");

        // Crear el arreglo bidimensional (matriz) y el arreglo unidimensional (vector)
        arr2D = new int[renglones, columnas];
        arr1D = new int[columnas];
        int[] resultado = new int[renglones];

        // Llenar la matriz con valores aleatorios
        for (int i = 0; i < renglones; i++)
        {
            for (int j= 0; j < columnas; j++)
            {
                arr2D[i, j] = Random.Range(1, 10); // Valores entre 1 y 10
            }
        }

        // Llenar el vector con valores aleatorios
        for (int i = 0 ; i < columnas ; i++)
        {
            arr1D[i] = Random.Range(1, 10); // Valores entre 1 y 10
        }

        // Multiplicar la matriz por el vector
        for (int i = 0; i < renglones; i++)
        {
            resultado[i] = 0; // Inicializar el resultado en 0
            for (int j = 0; j < columnas; j++)
            {
                resultado[i] += arr2D[i, j] * arr1D[j];
            }
        }

        // Imprimir la matriz
        Debug.Log("Matriz (arr2D):");
        for (int i = 0; i < renglones; i++)
        {
            int[] fila = new int[columnas]; // Arreglo temporal para almacenar los elementos de la fila
            for (int j = 0; j < columnas; j++)
            {
                fila[j] = arr2D[i, j];
            }
            Debug.Log("[" + string.Join(", ", fila) + "]");
        }

        // Imprimir el vector
        Debug.Log("Vector (arr1D): " + "[" + string.Join(", ", arr1D) + "]");

        // Imprimir el resultado
        Debug.Log("Resultado (Matriz * Vector): " + "[" + string.Join(", ", resultado) + "]");
    }
}
