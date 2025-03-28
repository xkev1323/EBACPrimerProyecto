using UnityEngine;

public class CambiarColorEnFixedUpdate : MonoBehaviour
{
    public GameObject prefabGO;

    private void FixedUpdate()
    {
        GameObject tempGameObject = prefabGO;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    }
}
