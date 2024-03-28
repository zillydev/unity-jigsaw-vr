using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CollisionDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // grabInteractable = GetComponent<XRGrabInteractable>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* private void OnTriggerEnter(Collider other) {
        if (other.tag == "GridPlane") {
            grabInteractable.trackPosition = false;
            transform.position = other.transform.position;
        }
        Debug.Log("Collision detected");
    }

    private void OnTriggerLeave(Collider other) {
        if (other.tag == "GridPlane") {
            grabInteractable.trackPosition = true;
        }
    } */
}
