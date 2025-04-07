using UnityEngine;

public class VariablesBooleanas : MonoBehaviour
{
    public bool variable1;
    public bool variable2;
    public bool variable3;
    public int valor1 = 5;

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
    }
}
