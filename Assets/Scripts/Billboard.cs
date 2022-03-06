using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    private Transform camTarget;
    // Start is called before the first frame update
    void Start()
    {
        camTarget = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(transform.position + camTarget.rotation * Vector3.forward);
    }
}
