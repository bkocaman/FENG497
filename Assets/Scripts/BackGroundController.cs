using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGroundController : MonoBehaviour
{
    private RawImage rimg;

    public ScoreManager scoreManager;
    public Texture image1;
    public Texture image2;
    public Texture image3;
    public Texture image4;
    public Texture image5;
    public Texture image6;
    public Texture image7;

    public void Change_Image_Background()
    {
        rimg = this.GetComponent<RawImage>();

        int number = Random.Range(1,7);

        if (number == 1 && rimg != image1)
        {
            rimg.texture = image1;
        }
        else if(number == 2 && rimg != image2)
        {
            rimg.texture = image2;
        }
        else if (number == 3 && rimg != image3)
        {
            rimg.texture = image3;
        }
        else if (number == 4 && rimg != image4)
        {
            rimg.texture = image4;
        }
        else if (number == 5 && rimg != image5)
        {
            rimg.texture = image5;
        }
        else if (number == 6 && rimg != image6)
        {
            rimg.texture = image6;
        }
        else if (number == 7 && rimg != image7)
        {
            rimg.texture = image7;
        }
    } 
}
