using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batu : MonoBehaviour
{
    
    public float platformfall = 0.33f;
    private int say = 0;
    public float Yposition = 17.33f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    private void OnCollisionEnter2D(Collision2D collision)
    {

        say++;
        float negativePosition = platformfall * say;
            
        float position = Yposition - negativePosition;


            transform.position = new Vector3(transform.position.x, position, transform.position.z); //0.33 sayı in
        
        









        //say = say + 1;
        //if (say == 2)
        //{
        //    Debug.Log("Dokundu");
        //    //platform = GameObject.FindGameObjectWithTag("plat1batu");
        //    //platform.transform.position = new Vector3(0, -1, 0);
        //    transform.position = new Vector3(transform.position.x, 17.00f, transform.position.z); //0.33 sayı in
        //}
        //if (say == 3)
        //{
        //    transform.position = new Vector3(transform.position.x, 16.67f, transform.position.z);
        //}

    }
}
