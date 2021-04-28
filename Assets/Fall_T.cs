using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall_T : MonoBehaviour
{

   



    void OnTriggerEnter(Collider other)

    {
        if (other.CompareTag("Player"))
        {

            StartCoroutine("Wait");


        }





    }


    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);
        transform.localPosition -= new Vector3(0, 2, 0);



    }




    private void WaitForSeconds(float v)
    {
        throw new NotImplementedException();

    }
}
