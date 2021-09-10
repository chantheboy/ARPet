using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NeedsSliders : MonoBehaviour
{
    public GameObject gameManager;
    public string need;
    private Needs needs;
    private Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        needs = gameManager.GetComponent<Needs>();
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (need == "hunger") 
        {
            slider.value = needs.hunger;
        }
        else if (need == "fun")
        {
            slider.value = needs.fun;
        }
        else if (need == "social")
        {
            slider.value = needs.social;
        }
    }
}
