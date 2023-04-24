using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top : MonoBehaviour
{
    Rigidbody2D body;
    public float hiz=10;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.velocity = Vector2.right * hiz;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
