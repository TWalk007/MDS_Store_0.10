using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class HighlightController : MonoBehaviour {

    public Material[] ballMaterials = new Material[2];
    public Material[] pasteMaterials = new Material[2];

    public Material highlightMaterial;
    
    private Material startMaterial;

    private GameObject collidingObject;

    private void Start () {
        startMaterial = GetComponent<Renderer>().material;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision Triggered! Colliding with " + other.gameObject.name);
        GetComponent<Renderer>().material = highlightMaterial;
    }

    private void OnTriggerExit(Collider other)
    {
        GetComponent<Renderer>().material = startMaterial;
    }
}
