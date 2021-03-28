using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    private SpriteRenderer rend;

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Color c = rend.material.color;
        c.a = 0f;
        rend.material.color = c;
        StartFadingIn();
    }

    // FADE OUT //
    IEnumerator FadeOut()
    {
        for (float f = 0.05f; f <= 1; f -= 0.05f)
        {
            Color c = rend.material.color;
            c.a = f;
            rend.material.color = c;
            yield return new WaitForSeconds(0.05f);
        }
    }

    public void StartFadingOut()
    {
        StartCoroutine("FadeOut");
    }
    // FADE OUT //

    // ---------------------------------------  //

    // FADE IN //
    IEnumerator FadeIn()
    {
        for (float f = 0.05f; f <= 1; f += 0.05f)
        {
            Color c = rend.material.color;
            c.a = f;
            rend.material.color = c;
            yield return new WaitForSeconds(0.05f);
        }
    }

    public void StartFadingIn()
    {
        StartCoroutine("FadeIn");
    }
    // FADE IN //
}
