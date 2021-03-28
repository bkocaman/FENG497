using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider slider;

    void Start()
    {
        slider.minValue = 0;
        slider.maxValue = 100;
        slider.wholeNumbers = true;
        slider.value = 5;
    }


    public void SetSliderValue(float value)
    {
        slider.value += value;

        if(slider.value >= slider.maxValue)
        {
            slider.value = slider.minValue = 0;
        }
    }
}
