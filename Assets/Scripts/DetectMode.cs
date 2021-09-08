using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectMode : MonoBehaviour
{
    public GameObject cameraImage;
    private PhoneARCamera phoneARCamera;

    // Start is called before the first frame update
    void Start()
    {
        phoneARCamera = cameraImage.GetComponent<PhoneARCamera>();
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
