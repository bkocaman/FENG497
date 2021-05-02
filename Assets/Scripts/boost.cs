using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boost : MonoBehaviour
{
    Rigidbody2D rb2d;
    private GameObject player;

    void Start()
    {
        
    }

    void Droplatform()
    {
        rb2d.isKinematic = false;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" && GameObject.Find("Player").GetComponent<Rigidbody2D>().velocity.y == 0)
            Debug.Log("hitting");



    }
}