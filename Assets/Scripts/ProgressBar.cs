using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Transform whiskeyGlass;
    public Transform finish;

    private float zEndPoint;
    private Slider slider;

    private void Start()
    {
        slider = GetComponent<Slider>();
        zEndPoint = finish.transform.position.z;

        slider = GetComponent<Slider>();
        slider.maxValue = Mathf.Abs(zEndPoint - whiskeyGlass.transform.position.z);
        slider.value = 0;
    }

    private void Update()
    {
        if (whiskeyGlass)
        {
            float zWhiskeyGlass = whiskeyGlass.transform.position.z;
            slider.value = slider.maxValue - Mathf.Abs(zEndPoint - zWhiskeyGlass);
        }
    }
}
