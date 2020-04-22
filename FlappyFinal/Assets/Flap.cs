using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flap : MonoBehaviour
{
    public Rigidbody bird;


    void Update()
    {
        bird = gameObject.GetComponent<Rigidbody>();


        if (Input.GetKeyDown("space"))
        {
            Debug.Log("flap!");
            bird.velocity = new Vector3(0, 0, 0);
            bird.AddForce(new Vector3(0, 400, 0));
        }

    }
}
