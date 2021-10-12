using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    public string carModel = "Huracan Evo";
    public string engineType = " Naturally Aspirated V10";
    public int carWeight = 1665;
    public int yearMade = 2019;
    public float maxAcceleration = 1.06;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = false;
    public  int carAge;
    public string carMaker= "Lamborghini";

    // Start is called before the first frame update

    public class Fuel
    {
        int fuelLevel;

        public Fuel(int amount)
        {
            fuelLevel = amount;
        }

    }

    public Fuel carFuel = new Fuel(100);

    void Start()
    {
        
        print("The racer model is " + carModel + " by " + carMaker + ". It has a " + engineType + " engine.");
        print("previous step");
        CheckWeight();
        if (yearMade >= 2009)
        {
            print("what year the car was introduced in, using the " + yearMade);
            carAge = CalculateAge(yearMade);
            print("the age of the car" + carAge);
        }
        else
        {
            print("the car was introduced in the 2010’s");
            print("car’s maximum acceleration" + maxAcceleration);
        }

        CheckCharacteristics();


    }

    // Update is called once per frame
    void Update()
    {

    }

    void CheckWeight()
    {
        if (carWeight < 1500)
        {
            print(carModel + "less than 1500 kg ");
        }
        else
        {
            print(carModel + "over 1500 kg ");
        }
    }



    int CalculateAge(int yearMade)
    {
        return 2021 - yearMade;
    }

    string CheckCharacteristics()
    {
        if (isCarTypeSedan)
        {
            return "The car is a sedan type.";

        }
        else if (hasFrontEngine)
        {
            return "The car is not a sedan, but has a front engine.";

        }
        else
        {
            return "The car is neither a sedan, nor is its engine a front engine.";
        }
    }
}
