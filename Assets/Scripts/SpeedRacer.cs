
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class SpeedRacer : MonoBehaviour
{
   
    public string carModel = "Huracan Evo";
    public string engineType = " Naturally Aspirated V10";
    public int carWeight = 1665;
    public int yearMade = 2019;
    public float maxAcceleration = 1.06f;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = false;
   // public  int carAge;
    public string carMaker= "Lamborghini";
    public GameObject carInfo;
    public GameObject carAge;
    public GameObject fuelLevel;
    public GameObject checkWeight;
    public GameObject checkCharacteristics;

    public Text trt;
    public Button myButton;

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

        //print("The racer model is " + carModel + " by " + carMaker + ". It has a " + engineType + " engine.");
        //print("previous step");
        string carText = "he racer model is: " + carModel + "\n" + "by: " + carMaker + "\n" + "Engine: " + engineType;
        SendText(carInfo, carText);
        CheckWeight();
        string carAgeText;
        if (yearMade >= 2009)
        {
            //print("what year the car was introduced in, using the " + yearMade);
            carAge = CalculateAge(yearMade);
           // print("the age of the car" + carAge);
            carAgeText = "what year the car was introduced in, using the  " + yearMade + "\n" + "The age of the car is " + carAge;
            SendText(carAge, carAgeText);
        }
        else
        {
            // print("the car was introduced in the 2010’s");
            //print("car’s maximum acceleration" + maxAcceleration);
            carAgeText = "The car was introduced in the 2010’s" + "\n" + "The car’s maximum acceleration is " + maxAcceleration;
            SendText(carAge, carAgeText);
        }

        CheckCharacteristics();
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);


    }

    // Update is called once per frame
    void Update()
    {

    }

    void CheckWeight()
    {
        string checkWeightText;
        if (carWeight < 1500)
        {

            checkWeightText = carModel + " weighs less than 1500 kg";
            SendText(checkWeight, checkWeightText)
        }
        else
        {
            //print(carModel + "over 1500 kg ");
            checkWeightText = carModel + " weighs over 1500 kg";
            SendText(checkWeight, checkWeightText);
        }
    }

    void ConsumeFuel()
    {
        carFuel.fuelLevel = carFuel.fuelLevel - 10;
    }

    void CheckFuelLevel()
    {
        string fuelLevelText;
        switch (carFuel.fuelLevel)
        {
            case 70:
                fuelLevelText = "fuel level is nearing two-thirds";
                SendText(fuelLevel, fuelLevelText);
                break;
            case 50:
                fuelLevelText = "fuel level is at half amount";
                SendText(fuelLevel, fuelLevelText);
                break;
            case 10:
                fuelLevelText = "Warning! Fuel level is critically low";
                SendText(fuelLevel, fuelLevelText);
                break;
            default:
                fuelLevelText = "there's nothing to report";
                SendText(fuelLevel, fuelLevelText);
                break;
        }
          Button btn = myButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    int CalculateAge(int yearMade)
    {
        return 2021 - yearMade;
    }

    string CheckCharacteristics()
    {
        if (isCarTypeSedan)
        {
         
            SendText(checkCharacteristics, "The car is a sedan type");

        }
        else if (hasFrontEngine)
        {

            SendText(checkCharacteristics, "The car is not a sedan, but has a front engine.");

        }
        else
        {
           
            SendText(checkCharacteristics, "The car is neither a sedan nor does it have a front engine");
        }
    }


    void ConsumeFuel()
    {
        carFuel.fuelLevel = carFuel.fuelLevel - 10;
    }

    void SendText(GameObject gameObject, string editedText)
    {
        gameObject.GetComponent<Text>().text = editedText;
    }

    void TaskOnClick()
    {
      
        ConsumeFuel();
        CheckFuelLevel();
    }


}
