using UnityEngine;

public class CambioColorOperadores : MonoBehaviour
{
    public GameObject cubo3;
    public GameObject cubo4;
    public GameObject cubo5;

    public bool isActive;

    private void FixedUpdate()
    {
        GameObject tempGameObject = cubo5;
        bool tempIsActive1 = cubo3.GetComponent<CambioColorAND>().isActive;
        bool tempIsActive2 = cubo4.GetComponent<CambioColorOR>().isActive;
        isActive = (tempIsActive1 || tempIsActive2) ? true : false;

        Color c = (isActive) ? Color.white : Color.black;
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    }
}
