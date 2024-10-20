using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    // Start is called before the first frame updat

    // Update is called once per frame
    public static float speed;

    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * speed;
        if(transform.position.x < -5)
        {
            //transform.position += Vector3.right * 7f + Vector3.up * Random.Range(-2,2);
            transform.position = new Vector3(5, Random.Range(-4f, -2f), 0);
        }
    }

}
