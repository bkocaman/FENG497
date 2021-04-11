using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin45Deg : MonoBehaviour
{

    private float Rot;
    public float DanglingSpeed;
    private float Time_Limit;

 
    // Update is called once per frame
    void Update()
    {



        transform.rotation = Quaternion.Euler(0, 0, Rot);





    }
}
