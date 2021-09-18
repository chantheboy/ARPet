using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomiseSkin : MonoBehaviour
{
    private Challenges challenges;
    private string skinColour;
    public Material defaultSkin;
    public Material blueSkin;
    public Material greenSkin;
    public Material pinkSkin;
    private SkinnedMeshRenderer render;
    private Material[] mats;


    // Start is called before the first frame update
    void Start()
    {
        challenges = FindObjectOfType<Challenges>();
        skinColour = "default";
        render = GetComponent<SkinnedMeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (skinColour != challenges.skinColour)
        {
            mats = render.materials;
            if (challenges.skinColour == "default")
            {
                mats[0] = defaultSkin;
            }
            else if (challenges.skinColour == "green")
            {
                if (challenges.animal)
                {
                    mats[0] = greenSkin;
                }
            }
            else if (challenges.skinColour == "blue")
            {
                if (challenges.vehicle)
                {
                    mats[0] = blueSkin;
                }
            }
            else if (challenges.skinColour == "pink")
            {
                if (challenges.food)
                {
                    mats[0] = pinkSkin;
                }
            }
            render.materials = mats;
            skinColour = challenges.skinColour;
        }
    }
}
