using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class VRRig : MonoBehaviour
{

    public Transform headConstraint;
    public Vector3 headBodyOffest;

    // Start is called before the first frame update
    void Start()
    {
        headBodyOffest = transform.position - headConstraint.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = headConstraint.position + headBodyOffest;
        transform.forward = Vector3.ProjectOnPlane(headConstraint.up, Vector3.up).normalized;
 
    }
}
