using UnityEngine;

public class VariablesBooleanas : MonoBehaviour
{
    public bool variable1;
    public bool variable2;
    public bool variable3;
    public int valor1 = 5;

    int limiteInferior = -5;
    int limiteSuperior = 5;

    enum SeleccionColor
    {
        Rojo,
        Verde,
        Azul,
        Blanco,
        Gris
    }

    // A B C    OR  AND ((A || B) && C)
    // 0 0 0    0   0       0
    // 0 0 1    0   0       0
    // 0 1 0    1   0       0
    // 0 1 1    1   0       1
    // 1 0 0    0   0       0
    // 1 0 1    0   0       1
    // 1 1 0    1   0       0
    // 1 1 1    1   1       1

    private void Start()
    {
        // Ejemplo de uso de las variables booleanas
        if ((variable1 || variable2) && variable3)
        {
            Debug.Log("La variable1 o la variable2 son verdaderas y la variable3 es verdadera");
        }
        else if (variable1 && !variable2)
        {
            Debug.Log("La variable1 es verdadera y la variable2 es falsa");
        }
        else if (variable1 && valor1 > 0)
        {
            Debug.Log("La variable1 es verdadera y el valor1 es mayor que 0");
        }
        else
        {
            Debug.Log("Ninguna de las condiciones anteriores se cumplió");
        }

        // Ejemplo de uso de la enumeración y switch

        valor1 = Random.Range(limiteInferior, limiteSuperior);
        Debug.Log(valor1);

        string resultado = (valor1 >= 0) ? "El valor es positivo" : "El valor es negativo";
        Debug.Log(resultado);

        switch (valor1)
        {
            case (int)SeleccionColor.Rojo:
                Debug.Log("El color seleccionado es Rojo");
                break;
            case (int)SeleccionColor.Verde:
                Debug.Log("El color seleccionado es Verde");
                break;
            case (int)SeleccionColor.Azul:
                Debug.Log("El color seleccionado es Azul");
                break;
            case (int)SeleccionColor.Blanco:
                Debug.Log("El color seleccionado es Blanco");
                break;
            case (int)SeleccionColor.Gris:
                Debug.Log("El color seleccionado es Gris");
                break;
            default:
                Debug.Log("El color seleccionado no es válido");
                break;
        }
    }
}
