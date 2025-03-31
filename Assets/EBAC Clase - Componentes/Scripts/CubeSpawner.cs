using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject prefabCubo;
    public List<GameObject> listaDeCubos;
    public float factorDeEscalamiento;
    public int numCubos = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        listaDeCubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        //Instanciar cubos y modificar sus componentes
        numCubos++;                                                         //Para nombrar los cubos con numeracion.
        GameObject tempGameObject = Instantiate<GameObject>(prefabCubo);    //Instanciar el cubo y para modificar lo guardamos en una variable local.
        tempGameObject.name = "CuboNumero" + numCubos;                      //Nombrar al cubo para distinguirlas.
        Color c = new Color(Random.value, Random.value, Random.value);      //La Clase Random va de 0 a 1 y en condigo de cambio de color va 0 a 1.
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;     //Cambiar el color del material.
        tempGameObject.transform.position = Random.insideUnitSphere;        //Posicionar dentro de una unidad de esfera porque estamos en 3D. (Para que no se vuelva loca)

        //Almacenar cubos (para optimizar y borrar cubos limitando)
        listaDeCubos.Add(tempGameObject);                                   //Almacenar en una lista de cubos al GameObjet temporal.
        List<GameObject> objetosParaEliminar = new List<GameObject>();      //Crea una lista de variable local para utilizar en eliminar dichos cubos.
        foreach (GameObject go in listaDeCubos)                             //Crea una variable local del loop para revisar la lista de cubos dentro de una funcion loop.
        {
            float scale = go.transform.localScale.x;                        //Crea una variable local del loop para almacenar la escala del gameobjet de la lista.
            scale *= factorDeEscalamiento;                                  //Usando matematicas, se multiplica el factor de escalamiento por su escala del cubo.
            go.transform.localScale = Vector3.one * scale;                  //Usando matematicas, la nueva escala del cubo es la multiplicacion del todas su escala por la variable local.

            if (scale <= 0.1)                                               //Condicional que revisa si su escala es menor al numero puesto.
            {
                objetosParaEliminar.Add(go);                                //Se almacena ese GameObjet a una nueva lista para su eliminacion.
            }
        }

        foreach (GameObject go in objetosParaEliminar)                      //Crea una variable local del loop para revisar la lista de objetos para eliminar de una funcion loop.
        {
            listaDeCubos.Remove(go);                                        //Remover el GameObjet de la lista de cubos con el GameObjet almacenado de la nueva lista.
            Destroy(go);                                                    //Destruyes en la escena el GameObjet de la nueva lista.
        }
    }
}
