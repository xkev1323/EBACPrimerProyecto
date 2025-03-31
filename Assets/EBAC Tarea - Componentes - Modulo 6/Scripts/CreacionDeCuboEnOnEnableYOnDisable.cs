using UnityEngine;

public class CreacionDeCuboEnOnEnableYOnDisable : MonoBehaviour
{
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
    private bool _isQuitting = false; //Variable para saber si la aplicacion se esta cerrando.

    private void OnEnable()
    {
        //Crear un cubo
        _numCubos++;                                                                     //Para nombrar los cubos con numeracion.
        _objToSpawn = new GameObject("Cubo Creado En OnEnable (" + _numCubos + ")");              //Inicializamos un GameObject con un nombre perzonalizado.
        //_objToSpawn.transform.SetParent(this.transform);                                //Se agrega como hijo de este GameObject.
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
    }

    private void OnDisable()
    {
        //Banderas para saber si la aplicacion se esta cerrando o no.
        if (_isQuitting) return;                                                         //Si la aplicacion se esta cerrando, entonces no se ejecuta el codigo.
        if (!Application.isPlaying) return;                                              //Si no esta en modo de juego, entonces no se ejecuta el codigo.

        //Crear un cubo
        _numCubos++;                                                                     //Para nombrar los cubos con numeracion.
        _objToSpawn = new GameObject("Cubo Creado En OnDisable (" + _numCubos + ")");              //Inicializamos un GameObject con un nombre perzonalizado.
         //_objToSpawn.transform.SetParent(this.transform);                                //Se agrega como hijo de este GameObject.
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
    }

    private void OnApplicationQuit()
    {
        _isQuitting = true; //Se cambia el valor de la variable a true.
    }
}
