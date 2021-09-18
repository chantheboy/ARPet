using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenges : MonoBehaviour
{
    public bool animal;
    public bool vehicle;
    public bool food;
    public int cat;
    public int dog;
    public int horse;
    public int bus;
    public int car;
    public int bicycle;
    public int apple;
    public int sandwich;
    public int pizza;
    public GameObject challengeList;
    public GameObject animalList;
    public GameObject vehicleList;
    public GameObject foodList;
    public string skinColour;


    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("date"))
        {
            cat = PlayerPrefs.GetInt("cat");
            dog = PlayerPrefs.GetInt("dog");
            horse = PlayerPrefs.GetInt("horse");
            car = PlayerPrefs.GetInt("car");
            bus = PlayerPrefs.GetInt("bus");
            bicycle = PlayerPrefs.GetInt("bicycle");
            apple = PlayerPrefs.GetInt("apple");
            sandwich = PlayerPrefs.GetInt("sandwich");
            pizza = PlayerPrefs.GetInt("pizza");
            skinColour = PlayerPrefs.GetString("skin");
        }
        else
        {
            cat = 0;
            dog = 0;
            horse = 0;
            car = 0;
            bus = 0;
            bicycle = 0;
            apple = 0;
            sandwich = 0;
            pizza = 0;
            skinColour = "default";
        }

        animal = false;
        vehicle = false;
        food = false;
        CheckChallenges();

        animalList.SetActive(false);
        vehicleList.SetActive(false);
        foodList.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChallengeList(string category)
    {
        if (category == "animal")
        {
            challengeList.SetActive(false);
            animalList.SetActive(true);
        }
        else if (category == "vehicle")
        {
            challengeList.SetActive(false);
            vehicleList.SetActive(true);
        }
        else if (category == "food")
        {
            challengeList.SetActive(false);
            foodList.SetActive(true);
        }
        else if (category == "challenge")
        {
            animalList.SetActive(false);
            vehicleList.SetActive(false);
            foodList.SetActive(false);
            challengeList.SetActive(true);
        }
    }
    
    public void CheckItem(string item)
    {
        if (item == "cat")
        {
            if (cat == 0)
            {
                cat = 1;
            }
        }
        else if (item == "dog")
        {
            if (dog == 0)
            {
                dog = 1;
            }
        }
        else if (item == "horse")
        {
            if (horse == 0)
            {
                horse = 1;
            }
        }
        else if (item == "car")
        {
            if (car == 0)
            {
                car = 1;
            }
        }
        else if (item == "bus")
        {
            if (bus == 0)
            {
                bus = 1;
            }
        }
        else if (item == "bicycle")
        {
            if (bicycle == 0)
            {
                bicycle = 1;
            }
        }
        else if (item == "apple")
        {
            if (apple == 0)
            {
                apple = 1;
            }
        }
        else if (item == "sandwich")
        {
            if (sandwich == 0)
            {
                sandwich = 1;
            }
        }
        else if (item == "pizza")
        {
            if (pizza == 0)
            {
                pizza = 1;
            }
        }
        CheckChallenges();
    }

    public void CheckChallenges()
    {
        if (cat == 1 && dog == 1 & horse == 1)
        {
            animal = true;
        }
        else
        {
            animal = false;
        }

        if (car == 1 && bus == 1 & bicycle == 1)
        {
            vehicle = true;
        }
        else
        {
            vehicle = false;
        }

        if (apple == 1 && sandwich == 1 && pizza == 1)
        {
            food = true;
        }
        else
        {
            food = false;
        }
    }

    public void ChangeColour(string challenge)
    {
        if (challenge == "default")
        {
            skinColour = "default";
        }
        else if (challenge == "animal")
        {
            if (animal)
            {
                skinColour = "green";
            }
        }
        else if (challenge == "vehicle")
        {
            if (vehicle)
            {
                skinColour = "blue";
            }
        }
        else if (challenge == "food")
        {
            if (food)
            {
                skinColour = "pink";
            }
        }
    }
}
