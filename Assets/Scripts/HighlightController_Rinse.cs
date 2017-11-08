using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightController_Rinse : MonoBehaviour {

    private GameObject bottle;
    private Transform bottleTrans;

    public Material[] materials = new Material[2];

    private void Start()
    {
        bottleTrans = gameObject.transform.Find("Rinse_BTL");
        bottle = bottleTrans.gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Controller (left)" || other.gameObject.name == "Controller (right)")
        {
            bottle.GetComponent<Renderer>().material = materials[1];
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Controller (left)" || other.gameObject.name == "Controller (right)")
        {
            bottle.GetComponent<Renderer>().material = materials[0];
        }
    }
}
