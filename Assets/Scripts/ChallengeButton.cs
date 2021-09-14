using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChallengeButton : MonoBehaviour
{
    public GameObject gameManager;
    private Challenges challenges;
    public Sprite tick;
    public Sprite empty;
    private Image check;
    public string item;

    // Start is called before the first frame update
    void Start()
    {
        challenges = gameManager.GetComponent<Challenges>();
        check = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((item == "cat" && challenges.cat == 1) || 
            (item == "dog" && challenges.dog == 1) ||
            (item == "horse" && challenges.horse == 1) ||
            (item == "car" && challenges.car == 1) ||
            (item == "bus" && challenges.bus == 1) ||
            (item == "bicycle" && challenges.bicycle == 1) ||
            (item == "apple" && challenges.apple == 1) ||
            (item == "sandwich" && challenges.sandwich == 1) ||
            (item == "pizza" && challenges.pizza == 1) ||
            (item == "animal" && challenges.animal) ||
            (item == "vehicle" && challenges.vehicle) ||
            (item == "food" && challenges.food))
        {
            check.sprite = tick;
        }
        else
        {
            check.sprite = empty;
        }
    }
}
