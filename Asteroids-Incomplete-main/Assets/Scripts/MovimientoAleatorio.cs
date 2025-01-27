using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MovimientoAleatorio : MonoBehaviour
{
    public float min_force = -50;
    public float max_force = 50;
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector3(Random.Range(min_force, max_force), Random.Range(min_force, max_force)));
        transform.eulerAngles += new Vector3(0, 0, Random.Range(min_force, max_force));
    }
}
