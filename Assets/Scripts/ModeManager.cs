using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeManager : MonoBehaviour
{
    public string mode;
    public string anim;
    public GameObject cameraImage;
    private PhoneARCamera phoneARCamera;
    public Text detectText;
    private string item;
    private string category;
    public Vector3 locationScreen;
    public Vector3 locationGame;
    private Dictionary<string, string> categories;
    private Needs needs;
    private Challenges challenges;
    private TouchControls touchControls;
    public GameObject challengeUI;
    public GameObject detectUI;
    public GameObject customUI;


    // Start is called before the first frame update
    void Start()
    {
        mode = "idle";
        challengeUI.SetActive(false);
        detectUI.SetActive(false);
        customUI.SetActive(false);
        phoneARCamera = cameraImage.GetComponent<PhoneARCamera>();
        categories = GetComponent<Lists>().categories;
        needs = GetComponent<Needs>();
        challenges = GetComponent<Challenges>();
        touchControls = GetComponent<TouchControls>();

    }

    // Update is called once per frame
    void Update()
    {
        if (mode == "detect")
        {
            if (phoneARCamera.boxSavedOutlines.Count > 0)
            {
                item = phoneARCamera.boxSavedOutlines[0].Label;
                locationScreen = phoneARCamera.boxSavedOutlines[0].Rect.center;
                phoneARCamera.enabled = false;
                category = categories[item];
                challenges.CheckItem(item);
                if (category == "hunger" || category == "fun" || category == "social")
                {
                    detectText.text = "You found a " + item + "!\nYour " + category + " increases!";
                    locationGame = Camera.main.ScreenToWorldPoint(locationScreen) + Camera.main.transform.forward;
                    touchControls.destination = locationGame;
                    needs.AddNeed(category);
                    anim = "cheer";
                    mode = "idle";
                }
                else
                {
                    phoneARCamera.enabled = true;
                    phoneARCamera.OnRefresh();
                }
            }
        }
    }

    public void ChangeMode(string newmode)
    {
        if (mode == newmode)
        {
            detectUI.SetActive(false);
            phoneARCamera.enabled = false;
            challengeUI.SetActive(false);
            customUI.SetActive(false);
            mode = "idle";
        }
        else if (newmode == "detect")
        {
            challengeUI.SetActive(false);
            customUI.SetActive(false);
            detectUI.SetActive(true);
            detectText.text = "Scanning...";
            phoneARCamera.enabled = true;
            if (phoneARCamera.boxSavedOutlines.Count > 0)
            {
                phoneARCamera.OnRefresh();
            }
            mode = newmode;
        }
        else if (newmode == "challenge")
        {
            customUI.SetActive(false);
            detectUI.SetActive(false);
            phoneARCamera.enabled = false;
            challengeUI.SetActive(true);
            mode = newmode;
        }
        else if (newmode == "custom")
        {
            detectUI.SetActive(false);
            phoneARCamera.enabled = false;
            challengeUI.SetActive(false);
            customUI.SetActive(true);
            mode = newmode;
        }
    }
}
