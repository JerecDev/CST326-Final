using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flap : MonoBehaviour
{
    public Rigidbody bird;
    public GameObject birdSprite;


    void Update()
    {
        bird = gameObject.GetComponent<Rigidbody>();


        if (Input.GetKeyDown("space"))
        {
            bird.velocity = new Vector3(0, 0, 0);
            bird.AddForce(new Vector3(0, 350, 0));
        }

    }

    private void OnCollisionEnter(Collision col)
    {
        Destroy(birdSprite);
        Destroy(col.gameObject);
        Debug.Log("Collision!");
    }

}
