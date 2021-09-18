using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SaveLoad : MonoBehaviour
{
    private Needs needs;
    private Challenges challenges;
    private double minutesDouble;
    public float minutesPassed;
    private float savedHunger;
    private float savedFun;
    private float savedSocial;
    private int savedCat;
    private int savedDog;
    private int savedHorse;
    private int savedBus;
    private int savedCar;
    private int savedBicycle;
    private int savedApple;
    private int savedSandwich;
    private int savedPizza;
    private string savedSkin;


    // Start is called before the first frame update
    void Start()
    {
        needs = GetComponent<Needs>();
        challenges = GetComponent<Challenges>();
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
        savedCat = challenges.cat;
        savedDog = challenges.dog;
        savedHorse = challenges.horse;
        savedBus = challenges.bus;
        savedCar = challenges.car;
        savedBicycle = challenges.bicycle;
        savedApple = challenges.apple;
        savedSandwich = challenges.sandwich;
        savedPizza = challenges.pizza;
        savedSkin = challenges.skinColour;

        DateTime currentDate = DateTime.Now;
        long dateBinary = currentDate.ToBinary();
        string dateString = Convert.ToString(dateBinary);
        PlayerPrefs.SetString("date", dateString);

        PlayerPrefs.SetFloat("hunger", savedHunger);
        PlayerPrefs.SetFloat("fun", savedFun);
        PlayerPrefs.SetFloat("social", savedSocial);

        PlayerPrefs.SetInt("cat", savedCat);
        PlayerPrefs.SetInt("dog", savedDog);
        PlayerPrefs.SetInt("horse", savedHorse);
        PlayerPrefs.SetInt("car", savedCar);
        PlayerPrefs.SetInt("bus", savedBus);
        PlayerPrefs.SetInt("bicycle", savedBicycle);
        PlayerPrefs.SetInt("apple", savedApple);
        PlayerPrefs.SetInt("sandwich", savedSandwich);
        PlayerPrefs.SetInt("pizza", savedPizza);

        PlayerPrefs.SetString("skin", savedSkin);

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
