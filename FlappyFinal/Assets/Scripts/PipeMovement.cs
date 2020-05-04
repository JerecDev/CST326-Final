using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public Rigidbody pipe;

    void Start()
    {
        pipe = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        pipe.velocity = new Vector3(-5, 0, 0);
    }
}
