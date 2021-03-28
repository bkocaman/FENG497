using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextureController : MonoBehaviour
{
    public Material texture1;
    public Material texture2;

    private bool state = true;

    void FixedUpdate()
    {
        if(GameObject.Find("Player").GetComponent<Rigidbody2D>().velocity.y == 0)
        {
            ChangeFace();
        }
    }

    public void ChangeFace()
    {
        if (state == true)
        {
            GetComponent<MeshRenderer>().material = texture2;
            state = false;
        }
        else
        {
            GetComponent<MeshRenderer>().material = texture1;
            state = true;
        }
    }
}
