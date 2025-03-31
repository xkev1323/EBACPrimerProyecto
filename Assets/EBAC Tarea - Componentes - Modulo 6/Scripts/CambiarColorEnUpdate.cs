using UnityEngine;

public class CambiarColorEnUpdate : MonoBehaviour
{
    public GameObject prefabGO;

    private void Update()
    {
        GameObject tempGameObject = prefabGO;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    }
}
