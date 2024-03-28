using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;

public class CollisionDetect : MonoBehaviour
{
    [SerializeField]
    private XRController _controller;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_controller) {
            if (_controller.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 axis)) {
                transform.position = _controller.transform.position + _controller.transform.forward * axis.y;
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log(other.name + " entered");
    }

    private void OnTriggerLeave(Collider other) {
        
    }
}
