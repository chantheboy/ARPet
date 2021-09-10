using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SaveLoad : MonoBehaviour
{
    private Needs needs;
    private double minutesDouble;
    public float minutesPassed;
    private float savedHunger;
    private float savedFun;
    private float savedSocial;

    // Start is called before the first frame update
    void Start()
    {
        needs = GetComponent<Needs>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveQuit()
    {
        savedHunger = needs.hunger;
        savedFun = needs.fun;
        savedSocial = needs.social;
        DateTime currentDate = DateTime.Now;
        long dateBinary = currentDate.ToBinary();
        string dateString = Convert.ToString(dateBinary);
        PlayerPrefs.SetString("date", dateString);
        PlayerPrefs.SetFloat("hunger", savedHunger);
        PlayerPrefs.SetFloat("fun", savedFun);
        PlayerPrefs.SetFloat("social", savedSocial);
        Application.Quit();
    }

    public void Load()
    {
        if (PlayerPrefs.HasKey("date"))
        {
            string oldDateString = PlayerPrefs.GetString("date");
            long oldDateBinary = Convert.ToInt64(oldDateString);
            DateTime oldDate = DateTime.FromBinary(oldDateBinary);
            DateTime currentDate = DateTime.Now;
            TimeSpan dateDifference = currentDate.Subtract(oldDate);
            minutesDouble = dateDifference.TotalMinutes;
            minutesPassed = (float)minutesDouble;
        }
    }
}
