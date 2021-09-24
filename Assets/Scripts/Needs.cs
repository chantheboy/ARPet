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
    private bool addHunger;
    private bool addFun;
    private bool addSocial;
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
        if (addHunger)
        {
            if (hunger < 1)
            {
                hunger += Time.deltaTime / 2;
            }
            else
            {
                addHunger = false;
            }
            
        }
        else if (hunger > 0)
        {
            hunger -= Time.deltaTime / (minsHunger * 60);
        }

        if (addFun)
        {
            if (fun < 1)
            {
                fun += Time.deltaTime / 2;
            }
            else
            {
                addFun = false;
            }

        }
        else if (fun > 0)
        {
            fun -= Time.deltaTime / (minsFun * 60);
        }

        if (addSocial)
        {
            if (social < 1)
            {
                social += Time.deltaTime / 2;
            }
            else
            {
                addSocial = false;
            }

        }
        else if (social > 0)
        {
            social -= Time.deltaTime / (minsSocial * 60);
        }
    }

    public void AddNeed(string need)
    {
        if (need == "hunger")
        {
            addHunger = true;
        }
        else if (need == "fun")
        {
            addFun = true;
        }
        else if (need == "social")
        {
            addSocial = true;
        }
    }
}
