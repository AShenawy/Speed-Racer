using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeText : MonoBehaviour
{
    public string carModel = "Huracan Evo";
    public string carMaker = "Lamborghini";
    public string engineType = "Naturally Aspirated V10";
    public int carWeight = 1665;
    public int yearMade = 2019;
    public float maxAcceleration = 1.06f;


    //public GameObject carText;
    public Text textCarComponent;

    void Start()
    {
        textCarComponent.text = 
            " The racer car model" + carModel + carMaker +
            "\n The engine type" + engineType +
            "\n The car weighs " + carWeight +
            "\n The car was introduced " + yearMade +
            "\n The car's maximum acceleration" + maxAcceleration;
    }

   
}
