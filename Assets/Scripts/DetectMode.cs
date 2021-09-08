using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectMode : MonoBehaviour
{
    public PhoneARCamera phoneARCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateDetect()
    {
        if (phoneARCamera.enabled)
        {
            phoneARCamera.enabled = false;
        }
        else
        {
            phoneARCamera.enabled = true;
        }
        
    }

}
