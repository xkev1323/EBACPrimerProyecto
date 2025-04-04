using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Estoy en Awake");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hola Mundo");
        Debug.LogWarning("Hola Warning");
        Debug.LogError("Hola Error");

        Debug.Log("Estoy en Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogWarning("Estoy en Update");
    }

    private void FixedUpdate()
    {
        Debug.LogWarning("Estoy en Fixed Update");
    }

    private void LateUpdate()
    {
        Debug.LogError("Estoy en Late Update");
    }
}
