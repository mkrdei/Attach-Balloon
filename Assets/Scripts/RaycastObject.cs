using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastObject : MonoBehaviour
{
    public Transform fpsCamera;
    public GameObject prefabRopeAndBalloon;
    private GameObject ropeAndBalloon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;

            if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, 10000))
            {
                Debug.Log(hit.transform.name);

                ropeAndBalloon = Instantiate(prefabRopeAndBalloon);
                ropeAndBalloon.transform.Find("Armature").gameObject.GetComponent<RopeAttachment>().AttachRope(hit.transform, hit.point);
            }
        }
    }


}
