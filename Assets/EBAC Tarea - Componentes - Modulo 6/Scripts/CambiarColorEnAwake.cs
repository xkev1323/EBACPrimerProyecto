using UnityEngine;

public class CambiarColorEnAwake : MonoBehaviour
{
    public GameObject prefabGO;

    private void Awake()
    {
        GameObject tempGameObject = prefabGO;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    }
}
