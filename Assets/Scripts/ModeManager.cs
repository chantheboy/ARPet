using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeManager : MonoBehaviour
{
    private string mode;
    public GameObject cameraImage;
    private PhoneARCamera phoneARCamera;
    public Text detectText;
    private string item;
    private string category;
    private Dictionary<string, string> categories;


    // Start is called before the first frame update
    void Start()
    {
        mode = "idle";
        phoneARCamera = cameraImage.GetComponent<PhoneARCamera>();
        categories = GetComponent<Lists>().categories;
    }

    // Update is called once per frame
    void Update()
    {
        switch (mode)
        {
            case ("idle"):
                break;
            case ("detect"):
                if (phoneARCamera.boxSavedOutlines.Count > 0)
                {
                    item = phoneARCamera.boxSavedOutlines[0].Label;
                    category = categories[item];
                    detectText.text = "You found a " + item + "!\nYour " + category + " increases!";
                    phoneARCamera.enabled = false;
                    mode = "idle";
                }
                break;
        }
    }

    public void ChangeMode(string newmode)
    {
        if (newmode == "detect")
        {
            detectText.text = "Scanning...";
            mode = newmode;
            phoneARCamera.enabled = true;
            phoneARCamera.OnRefresh();
        } 
    }
}
