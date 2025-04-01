using System.Collections.Generic;
using UnityEngine;

public class CreacionDeCuboEnUpdate : MonoBehaviour
{
    [Header("Prefab")]
    public GameObject cubo;

    [Header("Configuracion de Cubos")]
    public int limiteDeCubos = 10; //Variable para limitar el numero de cubos en la escena.

    private List<GameObject> _listaDeCubos; //Variable para almacenar los cubos creados.

    private int _numCubos = 0; //Variable para numerar los cubos.

    private void Start()
    {
        _listaDeCubos = new List<GameObject>(); //Inicializamos la lista de cubos.
    }

    private void Update()
    {
        if (_listaDeCubos.Count > limiteDeCubos) //Si el numero de cubos en la lista es mayor al limite de cubos permitidos, entonces...
        {
            //Eliminar un cubo aleatoriamente
            int indexToRemove = Random.Range(0, _listaDeCubos.Count); //Se elige un numero aleatorio entre 0 y el numero de cubos en la lista.
            GameObject cuboAEliminar = _listaDeCubos[indexToRemove]; //Se almacena el cubo a eliminar en una variable.
            _listaDeCubos.RemoveAt(indexToRemove); //Se elimina el cubo de la lista.
            Destroy(cuboAEliminar); //Se destruye el cubo en la escena.
        }
        else //Si no, entonces...
        {
            //Crear un cubo
            _numCubos++;                                                                     //Para nombrar los cubos con numeracion.
            GameObject tempObject = Instantiate(cubo);                                          //Inicializamos un GameObject con un nombre perzonalizado.
            tempObject.transform.name = "Cubo Creado En Update (" + _numCubos + ")";         //Se le asigna un nombre al GameObject.
            tempObject.transform.SetParent(this.transform);                                     //Se agrega como hijo de este GameObject.
            var meshRendererMaterial = tempObject.GetComponent<MeshRenderer>().material;        //Se crea una variable local para acceder el material de nuestro GameObject.
            Color c = new Color(Random.value, Random.value, Random.value);                      //La Clase Random va de 0 a 1 y en condigo de cambio de color va 0 a 1.
            meshRendererMaterial.color = c;                                                     //Le asignamos un color a nuestro material que es el color blanco.
            tempObject.transform.position = this.transform.position + Random.insideUnitSphere;  //Posicionamos el cubo cerca del padre.

            _listaDeCubos.Add(tempObject); //Se agrega el cubo a la lista de cubos.
        }
    }
}
