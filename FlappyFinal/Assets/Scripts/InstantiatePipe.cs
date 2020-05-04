using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePipe : MonoBehaviour
{
    public GameObject Pipe;
    public GameObject uPipe;
    int counter = 0;
    int x = 70;
    float xDifference = 1.27f;

    void Start()
    {
        Instantiate(uPipe, new Vector3(28f - xDifference, 10.0f, -1f), Quaternion.identity);
        Instantiate(Pipe, new Vector3(28f, -6.0f, -1f), Quaternion.identity);

        Instantiate(uPipe, new Vector3(38f - xDifference, 9.0f, -1f), Quaternion.identity);
        Instantiate(Pipe, new Vector3(38f, -7.0f, -1f), Quaternion.identity);

        Instantiate(uPipe, new Vector3(48f - xDifference, 6.0f, -1f), Quaternion.identity);
        Instantiate(Pipe, new Vector3(48f, -10.0f, -1f), Quaternion.identity);

        Instantiate(uPipe, new Vector3(58f - xDifference, 10.0f, -1f), Quaternion.identity);
        Instantiate(Pipe, new Vector3(58f, -6.0f, -1f), Quaternion.identity);

        /*
        Instantiate(uPipe, new Vector3(200f - xDifference, 10.0f, -1f), Quaternion.identity);
        Instantiate(Pipe, new Vector3(200f, -6.0f, -1f), Quaternion.identity);

        Instantiate(uPipe, new Vector3(202f - xDifference, 10.0f, -1f), Quaternion.identity);
        Instantiate(Pipe, new Vector3(202f, -6.0f, -1f), Quaternion.identity);

        Instantiate(uPipe, new Vector3(201f - xDifference, 10.0f, -1f), Quaternion.identity);
        Instantiate(Pipe, new Vector3(201f, -6.0f, -1f), Quaternion.identity);
        */

    }

    void Update()
    {
        while (counter < 50)
        {
            float y1 = Random.Range(8, 10);
            float y2 = Random.Range(-y1, -y1 + 2);
            Instantiate(uPipe, new Vector3(x - xDifference, y1, -1f), Quaternion.identity);
            Instantiate(Pipe, new Vector3(x, y2, -1f), Quaternion.identity);

            x += 10;
            counter++;
        }
    }

}
