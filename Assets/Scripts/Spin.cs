using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class Spin : MonoBehaviour
{
    private float rot;
    public float RotateSpeed;
    public bool clockwiseRotation;



    // Update is called once per frame
    void Update()
    {
        if (clockwiseRotation == false)
        {
            rot += Time.deltaTime * RotateSpeed;
        }
        else
        {
            rot += -Time.deltaTime * RotateSpeed;
        }

        transform.rotation = Quaternion.Euler(0, 0, rot);
        
    }
}
