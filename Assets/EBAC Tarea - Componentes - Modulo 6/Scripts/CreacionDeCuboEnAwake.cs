using UnityEngine;

public class CreacionDeCuboEnAwake : MonoBehaviour
{
    [Header("Prefab")]
    public GameObject cubo;

    private void Awake()
    {
        GameObject tempObject = Instantiate(cubo);                                          //Inicializamos un GameObject con un nombre perzonalizado.
        tempObject.transform.SetParent(this.transform);                                     //Se agrega como hijo de este GameObject.
        var meshRendererMaterial = tempObject.GetComponent<MeshRenderer>().material;        //Se crea una variable local para acceder el material de nuestro GameObject.
        Color c = new Color(Random.value, Random.value, Random.value);                      //La Clase Random va de 0 a 1 y en condigo de cambio de color va 0 a 1.
        meshRendererMaterial.color = c;                                                     //Le asignamos un color a nuestro material que es el color blanco.
        tempObject.transform.position = this.transform.position + Random.insideUnitSphere;  //Posicionamos el cubo cerca del padre.
    }
}
