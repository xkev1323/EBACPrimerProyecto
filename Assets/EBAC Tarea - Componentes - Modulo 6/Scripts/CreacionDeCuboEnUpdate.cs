using System.Collections.Generic;
using UnityEngine;

public class CreacionDeCuboEnUpdate : MonoBehaviour
{
    [Header("Configuracion de Cubos")]
    public int limiteDeCubos = 10; //Variable para limitar el numero de cubos en la escena.

    private List<GameObject> _listaDeCubos; //Variable para almacenar los cubos creados.

    GameObject _objToSpawn; //Variable para almacenar el cubo que se va a crear.
    Vector3[] _vertices =
    {
        new Vector3 (0,0,0), //Vertice 0
        new Vector3 (1,0,0), //Vertice 1
        new Vector3 (1,1,0), //Vertice 2
        new Vector3 (0,1,0), //Vertice 3
        new Vector3 (0,1,1), //Vertice 4
        new Vector3 (1,1,1), //Vertice 5
        new Vector3 (1,0,1), //Vertice 6
        new Vector3 (0,0,1)  //Vertice 7
    }; //Vertices de un cubo.

    int[] _triangulos =
    {
        0,2,1, //Cara 1
        0,3,2,
        2,3,4, //Cara 2
        2,4,5,
        1,2,5, //Cara 3
        1,5,6,
        0,7,4, //Cara 4
        0,4,3,
        5,4,7, //Cara 5
        5,7,6,
        0,6,7, //Cara 6
        0,1,6
    }; //Triangulos de un cubo.

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
            _objToSpawn = new GameObject("Cubo Creado En Update (" + _numCubos + ")");              //Inicializamos un GameObject con un nombre perzonalizado.
            _objToSpawn.transform.SetParent(this.transform);                                //Se agrega como hijo de este GameObject.
            _objToSpawn.AddComponent<MeshFilter>();                                         //Se agrega un componente que es MeshFilter para agregar sus vertices y triangulos, dar forma al cubo.
            var meshFilter = _objToSpawn.GetComponent<MeshFilter>().mesh;                   //Se crea una variable local para acceder al mesh de nuestro GameObject.
            meshFilter.Clear();                                                             //Limpiamos para que todo este en cero.
            meshFilter.vertices = _vertices;                                                //Agregamos los vertices.
            meshFilter.triangles = _triangulos;                                             //Agregamos las caras.
            meshFilter.Optimize();                                                          //Hay que optimizar una vez agregado las variables.
            meshFilter.RecalculateNormals();                                                //Recalculamos las normales para poder vizualizar las caras de nuestro cubo.
            _objToSpawn.AddComponent<BoxCollider>();                                        //Se agrega un componente que es BoxCollider para dar colision a nuestro cubo.
            var boxCollider = _objToSpawn.GetComponent<BoxCollider>();                      //Se crea una variable local para acceder el boxcollider de nuestro GameObject.
            boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);                             //Posicionamos el Collider en el centro de nuestro cubo con un poco de separacion.
            _objToSpawn.AddComponent<MeshRenderer>();                                       //Se agrega un componente que es MeshRenderer para dar material a nuestro cubo.
            var meshRendererMaterial = _objToSpawn.GetComponent<MeshRenderer>().material;   //Se crea una variable local para acceder el material de nuestro GameObject.
            Color c = new Color(Random.value, Random.value, Random.value);      //La Clase Random va de 0 a 1 y en condigo de cambio de color va 0 a 1.
            meshRendererMaterial.color = c;                                         //Le asignamos un color a nuestro material que es el color blanco.
            _objToSpawn.transform.position = this.transform.position + Random.insideUnitSphere;   //Posicionamos el cubo cerca del padre.

            _listaDeCubos.Add(_objToSpawn); //Se agrega el cubo a la lista de cubos.

            int numHijos = this.transform.childCount; //Se almacena el numero de hijos que tiene el padre.
        }
    }
}
