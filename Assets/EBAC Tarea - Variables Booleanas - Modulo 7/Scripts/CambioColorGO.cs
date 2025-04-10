using UnityEngine;

public class CambioColorGO : MonoBehaviour
{
    public GameObject cubo;
    public bool isActive = true;

    private void FixedUpdate()
    {
        GameObject tempGameObject = cubo;
        Color c = (isActive) ? Color.white : Color.black;
        isActive = !isActive;
            
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    }
}
