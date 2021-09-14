using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectButton : MonoBehaviour
{
    public GameObject gameManager;
    private ModeManager modeManager;
    public Sprite detectStart;
    public Sprite detectStop;
    private Image detectButton;

    // Start is called before the first frame update
    void Start()
    {
        modeManager = gameManager.GetComponent<ModeManager>();
        detectButton = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (modeManager.mode != "detect")
        {
            detectButton.sprite = detectStart;
        }
        else
        {
            detectButton.sprite = detectStop;
        }
    }
}
