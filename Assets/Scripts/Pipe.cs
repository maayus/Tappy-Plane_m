using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        var position = transform.position;
        position.y += Random.Range(-1.5f, 1.5f);
        transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < -20)
        {
            Destroy(gameObject);
        }
    }
}
