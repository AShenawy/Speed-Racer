using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarTextContoroller : MonoBehaviour
{
    public string carMaker;

    public string carModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";
    public int carWeight = 1609;
    public int yearMade = 2009;
    public float maxAcceleration = 0.98f;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;

    string carFuelMessage = null;

    //sub class
    public class Fuel
    {
        public int fuelLevel;

        //constructor
        public Fuel(int amount)
        {
            fuelLevel = amount;
        }
    }

    //instance
    public Fuel carFuel = new Fuel(100);
    
    public void Start()
    {
        Text carInfoText = GameObject.Find("CarInfoText").GetComponent<Text>();

        carInfoText.text = CarIntroduction() + CheckWeight() + CarInfo() + CheckCharacteristics();

        print(carInfoText.text);
    }


    public string CarIntroduction()
    {
        return "The car model is " + carModel + " created by " + carMaker + ". And the engine type is " + engineType + ".\n";
    }

    public string CheckWeight()
    {
        if (carWeight < 1500)
        {
            return "The " + carModel + " weighs less than 1500 kg.\n";
        }
        else
        {
            return "The " + carModel + " weighs over 1500 kg.\n";
        }
    }

    public string CarInfo()
    {
        if (yearMade <= 2009)
        {
            int carAge = CalculateAge(yearMade);
            string carInfoMessage1 = "The car was introduced in " + yearMade + ".\n" + "The age of the car is " + carAge + ".\n";
            return carInfoMessage1;
        }
        else
        {
            string carInfoMessage2 = "The car was introduced in the 2010’s.\n" + "The car’s maximum acceleration is " + maxAcceleration + ".\n";
            return carInfoMessage2;
        }
    }

    public int CalculateAge(int yearMade)
    {
        return 2021 - yearMade;
    }

    public string CheckCharacteristics()
    {

        if (isCarTypeSedan == true)
        {
            return "The car type is a sedan.\n";
        }
        else
        {
            if (hasFrontEngine == true)
            {
                return "The car isn’t a sedan, but has a front engine.\n";
            }
            else
            {
                return "The car is neither a sedan nor does it have a front engine.\n";
            }
        }
    }

    public void ConsumeFuel()
    {
        carFuel.fuelLevel -= 10;
    }

    public void CheckFuelLevel()
    {
        switch (carFuel.fuelLevel)
        {
            case 70:
                carFuelMessage = "Fuel level is nearing two-thirds.\n";
                print(carFuelMessage);
                break;
                
            case 50:
                carFuelMessage = "Fuel level is at half amount.\n";
                print(carFuelMessage);
                break;

            case 10:
                carFuelMessage = "Warning! Fuel level is critically low.\n";
                print(carFuelMessage);
                break;

            default:
                carFuelMessage = "There’s nothing to report.\n";
                print(carFuelMessage);
                break;
        }
    }

    public void OnButtonClick()
    {
        ConsumeFuel();

        CheckFuelLevel();
        
        Text carFuelLevel = this.gameObject.GetComponent<Text>();

        carFuelLevel.text = carFuelMessage;
    }
}
