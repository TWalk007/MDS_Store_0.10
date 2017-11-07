using UnityEngine;

public class HighlightController : MonoBehaviour {

    public Material[] materials = new Material[2];

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Controller (left)" || other.gameObject.name == "Controller (right)")
        {
            Debug.Log("Collision detected!");
            GetComponent<Renderer>().material = materials[1];
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Controller (left)" || other.gameObject.name == "Controller (right)")
        {
            GetComponent<Renderer>().material = materials[0];
        }
    }
  }
