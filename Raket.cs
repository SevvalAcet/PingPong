using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raket : MonoBehaviour
{
    public float hiz = 10;
    public string eksenAdi;
    void Start()
    {
        
    }

    void Update()
    {
        float eksenHiz = Input.GetAxis(eksenAdi) * hiz;
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, eksenHiz);

    }
}
