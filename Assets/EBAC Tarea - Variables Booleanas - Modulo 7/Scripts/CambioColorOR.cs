using UnityEngine;

public class CambioColorOR : MonoBehaviour
{
    public GameObject cubo1;
    public GameObject cubo2;
    public GameObject cubo4;

    public bool isActive;

    private void FixedUpdate()
    {
        GameObject tempGameObject = cubo4;
        bool tempIsActive1 = cubo1.GetComponent<CambioColorGO>().isActive;
        bool tempIsActive2 = cubo2.GetComponent<CambioColorGO>().isActive;
        isActive = (tempIsActive1 || tempIsActive2) ? true : false;

        Color c = (isActive) ? Color.white : Color.black;
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    }
}
