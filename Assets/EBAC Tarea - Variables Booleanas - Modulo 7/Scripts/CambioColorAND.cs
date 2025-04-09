using UnityEngine;

public class CambioColorAND : MonoBehaviour
{
    public GameObject cubo1;
    public GameObject cubo2;
    public GameObject cubo3;

    public bool isActive;

    private void FixedUpdate()
    {
        GameObject tempGameObject = cubo3;
        bool tempIsActive1 = cubo1.GetComponent<CambioColorGO>().isActive;
        bool tempIsActive2 = cubo2.GetComponent<CambioColorGO>().isActive;
        isActive = (tempIsActive1 && tempIsActive2) ? true : false;

        Color c = (isActive) ? Color.white : Color.black;
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    }
}
