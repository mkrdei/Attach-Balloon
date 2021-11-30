using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeAttachment : MonoBehaviour
{
    private Rigidbody boneAttachedToObject;
    private CharacterJoint boneJoint, objectJoint;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AttachRope(Transform objectToAttach, Vector3 hitPoint)
    {
        transform.parent.position = objectToAttach.position;
        boneAttachedToObject = transform.GetChild(0).GetComponent<Rigidbody>();
        Debug.Log(transform.GetChild(0).name);
        boneJoint = boneAttachedToObject.GetComponent<CharacterJoint>();
        objectJoint = objectToAttach.gameObject.AddComponent<CharacterJoint>();
        objectJoint.connectedBody = boneAttachedToObject;
        //objectJoint.anchor = objectToAttach.InverseTransformPoint(hitPoint);
    }

    //Breadth-first search
    
}
