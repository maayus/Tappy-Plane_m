using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    public float scrollSpeed = 0.5f;

    public Renderer rend;
    public Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        offset = rend.material.mainTextureOffset;
    }

    // Update is called once per frame
    void Update()
    {
        offset.x += scrollSpeed * Time.deltaTime;
        rend.material.mainTextureOffset = offset;
    }
}
