using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UP_Down : MonoBehaviour
{


    public Rigidbody2D rb;
    public float Speed;
    public float RestartTimer;


    private void MoveUP()
    {
        rb.velocity = transform.up * Speed;
    }

    private void MoveDown()
    {
        rb.velocity = -transform.up * Speed;
    }

    private void Start()
    {

        InvokeRepeating("MoveUP", 0, RestartTimer);

        InvokeRepeating("MoveDown", RestartTimer / 2 , RestartTimer);



    }



}
