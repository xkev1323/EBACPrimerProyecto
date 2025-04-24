using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    //---Parte 1---
    [Header("Ejercicios Variables Modulo 8 / Parte 1")]
    [Space(10)]
    [Header("Incremento de dos variables numericas")]
    public bool paso1;
    [Header("Sumar dos numeros")]
    public bool paso2;
    //2) Crea dos variables flotantes...
    public float numF2 = 0.5f;
    public float numF3 = 0.5f;
    [Space(10)]
    [Header("Par o impar")]
    public bool paso3;
    [Header("Escoge un color: rojo, verde o azul")]
    public bool paso4;
    public string nombreColor; //4)
    [Space(10)]
    [Header("Convertir un numero flotante a string")]
    public bool paso5;
    [Header("Separar nombre completo")]
    public bool paso6;

    //1) Crea dos variables...
    int numE1 = 0;
    float numF1 = 1f;

    //5) Convertir un numero flotante a string...
    float numFString = 3.1415926f;

    //6) nombre completo para separar con el metodo substring y split en una lista de strings.
    string nombreCompleto = "Kevin Hernandez Amaya";
    string nombre;
    string apellido1;
    string apellido2;
    List<string> nombreSeparado = new List<string>();

    //---Parte 2---
    [Header("Ejercicios Variables Modulo 8 / Parte 2")]
    [Space(10)]
    [Header("Convertir string a int con tryparse")]
    public bool paso7;
    [Header("Oracion con caracteres en indice par")]
    public bool paso8;
    [Header("Eliminar los primeros 5 caracteres de la oracion")]
    public bool paso9;

    //1) Crea dos variables string que guarden valores numericos de miles...
    string numString1 = "1000";
    string numString2 = "2000";
    int resultadoSuma;

    //2)Crea un string con una oracion y imprimir solo los caracteres que se encuentre en un indice par...
    string oracion = "Hola Mundo";

    private void Start()
    {
        //---Parte 1---
        nombre = nombreCompleto.Substring(0, 5); //6) Kevin
        apellido1 = nombreCompleto.Substring(6, 9); //6) Hernandez
        apellido2 = nombreCompleto.Substring(16, 5); //6) Amaya

        nombreSeparado = nombreCompleto.Split(' ').ToList(); //6) Separa el nombre completo en una lista de strings

        //---Parte 2---
        int numInt1 = 0;
        int numInt2 = 0;
        int.TryParse(numString1, out numInt1); //1) Convierte el string a int
        int.TryParse(numString2, out numInt2); //1) Convierte el string a int

        resultadoSuma = numInt1 + numInt2; //1) Suma los dos numeros enteros

    }

    private void Update()
    {
        //---Parte 1---
        if (paso1) 
        {
            numE1 += 1; //1)
            Debug.Log("numF1: " + numF1 + " numE1: " + numE1); //1)
        }

        int resultado;
        if (paso2)
        {
            resultado = (int)(numF2 + numF3); //2)
            Debug.Log("Resultado: " + resultado); //2)
        }

        if (paso5) //5)
        {
            string numFStringConvertido = numFString.ToString("F4"); //5)
            Debug.Log("Variable float convertido en string: " + numFStringConvertido); //5)
        }

        if (paso6)
        {
            Debug.Log("Nombre completo: " + nombreCompleto); //6)
            Debug.Log("Nombre: " + nombre); //6)
            Debug.Log("Apellido 1: " + apellido1); //6)
            Debug.Log("Apellido 2: " + apellido2); //6)
            foreach (string nombre in nombreSeparado) //6)
            {
                Debug.Log("Nombre separado con split: " + nombre); //6)
            }
        }

        //---Parte 2---
        if (paso7)
        {
            Debug.Log("La suma de: " + numString1 + " + " + numString2); //1)
            Debug.Log("Resultado de la suma convertida de string a int con TryParse: " + resultadoSuma); //1)
        }

        if (paso8) //2)
        {
            Debug.Log("Oracion: " + oracion); //2)
            for (int i = 0; i < oracion.Length; i++) //2)
            {
                if (i % 2 == 0) //2)
                {
                    Debug.Log("Caracter en indice par: " + oracion[i]); //2)
                }
            }
        }

        if (paso9) //3)
        {
            Debug.Log("Oracion: " + oracion); //3)
            string oracionSin5Caracteres = oracion.Substring(5); //3)
            Debug.Log("Oracion sin los primeros 5 caracteres: " + oracionSin5Caracteres); //9)
        }
    }

    private void FixedUpdate()
    {
        //---Parte 1---
        if (paso1) 
        {
            numF1 *= 2f; //1)
            //Debug.Log("numF1: " + numF1 + " numE1: " + numE1); //1)
        }

        if (paso3 && !paso4) //3)
        {
            if (numE1 % 2 == 0) //3)
            {
                Debug.Log("numE1 es par: " + numE1);
                transform.GetComponent<MeshRenderer>().material.color = Color.white;
            }
            else
            {
                Debug.Log("numE1 es impar: " + numE1);
                transform.GetComponent<MeshRenderer>().material.color = Color.black;
            }
        }

        if (paso4) //4)
        {
            switch (nombreColor.ToLower())
            {
                case "rojo":
                    transform.GetComponent<MeshRenderer>().material.color = Color.red;
                    break;
                case "verde":
                    transform.GetComponent<MeshRenderer>().material.color = Color.green;
                    break;
                case "azul":
                    transform.GetComponent<MeshRenderer>().material.color = Color.blue;
                    break;
                default:
                    Debug.Log("Color no reconocido");
                    break;
            }
        }

    }
}
