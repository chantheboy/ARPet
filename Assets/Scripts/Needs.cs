using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Needs : MonoBehaviour
{

    //minsNeed = number of minutes it takes to empty the needs bar

    public float hunger;
    public float fun;
    public float social;
    private float savedHunger;
    private float savedFun;
    private float savedSocial;
    private float minsHunger = 5;
    private float minsFun = 4;
    private float minsSocial = 3;
    private SaveLoad saveLoad;

    // Start is called before the first frame update
    void Start()
    {
        saveLoad = GetComponent<SaveLoad>();

        if (PlayerPrefs.HasKey("date"))
        {
            saveLoad.Load();

            savedHunger = PlayerPrefs.GetFloat("hunger");
            savedFun = PlayerPrefs.GetFloat("fun");
            savedSocial = PlayerPrefs.GetFloat("social");

            if ((saveLoad.minutesPassed / minsHunger) < savedHunger)
            {
                hunger = savedHunger - (saveLoad.minutesPassed / minsHunger);
            }
            else
            {
                hunger = 0;
            }

            if ((saveLoad.minutesPassed / minsFun) < savedFun)
            {
                fun = savedFun - (saveLoad.minutesPassed / minsFun);
            }
            else
            {
                fun = 0;
            }

            if ((saveLoad.minutesPassed / minsSocial) < savedSocial)
            {
                social = savedSocial - (saveLoad.minutesPassed / minsSocial);
            }
            else
            {
                social = 0;
            }
        }
        else
        {
            hunger = 1;
            fun = 1;
            social = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (hunger > 0)
        {
            hunger -= Time.deltaTime / (minsHunger * 60);
        }

        if (fun > 0)
        {
            fun -= Time.deltaTime / (minsFun * 60);
        }

        if (social > 0)
        {
            social -= Time.deltaTime / (minsSocial * 60);
        }
    }

    public void AddNeed(string need)
    {
        if (need == "hunger")
        {
            hunger = 1;
        }
        else if (need == "fun")
        {
            fun = 1;
        }
        else if (need == "social")
        {
            social = 1;
        }
    }
}
