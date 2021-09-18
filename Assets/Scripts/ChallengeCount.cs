using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChallengeCount : MonoBehaviour
{
    public GameObject gameManager;
    private Challenges challenges;
    private Text text;
    public string challenge;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        challenges = gameManager.GetComponent<Challenges>();
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (challenge == "animal")
        {
            count = challenges.cat + challenges.dog + challenges.horse;
        }
        else if (challenge == "vehicle")
        {
            count = challenges.car + challenges.bus + challenges.bicycle;
        }
        else if (challenge == "food")
        {
            count = challenges.apple + challenges.sandwich + challenges.pizza;
        }
        else
        {
            count = 0;
        }
        text.text = count + "/3";
    }
}
