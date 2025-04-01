using UnityEngine;

public class CreacionDeCuboEnOnEnableYOnDisable : MonoBehaviour
{
    [Header("Prefab")]
    public GameObject cubo;

    private int _numCubos = 0; //Variable para numerar los cubos.
    private bool _isQuitting = false; //Variable para saber si la aplicacion se esta cerrando.

    private void OnEnable()
    {
        //Crear un cubo
        _numCubos++;                                                                     //Para nombrar los cubos con numeracion.
        GameObject tempObject = Instantiate(cubo);                                          //Inicializamos un GameObject con un nombre perzonalizado.
        tempObject.transform.name = "Cubo Creado En OnEnable (" + _numCubos + ")";         //Se le asigna un nombre al GameObject.
        var meshRendererMaterial = tempObject.GetComponent<MeshRenderer>().material;        //Se crea una variable local para acceder el material de nuestro GameObject.
        Color c = new Color(Random.value, Random.value, Random.value);                      //La Clase Random va de 0 a 1 y en condigo de cambio de color va 0 a 1.
        meshRendererMaterial.color = c;                                                     //Le asignamos un color a nuestro material que es el color blanco.
        tempObject.transform.position = this.transform.position + Random.insideUnitSphere;  //Posicionamos el cubo cerca del padre.
    }

    private void OnDisable()
    {
        //Banderas para saber si la aplicacion se esta cerrando o no.
        if (_isQuitting) return;                                                         //Si la aplicacion se esta cerrando, entonces no se ejecuta el codigo.
        if (!Application.isPlaying) return;                                              //Si no esta en modo de juego, entonces no se ejecuta el codigo.

        //Crear un cubo
        GameObject tempObject = Instantiate(cubo);                                          //Inicializamos un GameObject con un nombre perzonalizado.
        tempObject.transform.name = "Cubo Creado En OnDisable (" + _numCubos + ")";         //Se le asigna un nombre al GameObject.
        var meshRendererMaterial = tempObject.GetComponent<MeshRenderer>().material;        //Se crea una variable local para acceder el material de nuestro GameObject.
        Color c = new Color(Random.value, Random.value, Random.value);                      //La Clase Random va de 0 a 1 y en condigo de cambio de color va 0 a 1.
        meshRendererMaterial.color = c;                                                     //Le asignamos un color a nuestro material que es el color blanco.
        tempObject.transform.position = this.transform.position + Random.insideUnitSphere;  //Posicionamos el cubo cerca del padre.
    }

    private void OnApplicationQuit()
    {
        _isQuitting = true; //Se cambia el valor de la variable a true.
    }
}
