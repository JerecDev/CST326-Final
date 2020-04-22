using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody bird;
    void Start()
    {
        bird = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }
}
