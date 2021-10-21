using UnityEngine;
using UnityEngine.UI;

public class SpeedRacer : MonoBehaviour
{
    public class Fuel
    {
        public int fuelLevel;

        public Fuel(int amount)
        {
            fuelLevel = amount;
        }

    }

    public Fuel carFuel = new Fuel(100);

    public string carModel = " GTR R35 ";

    public string carMaker;

    public string engineType = " V6, Twin Turbo ";

    public int carWeight = 1609;

    public int yearMade = 2009;

    public float maxAcceleration = 0.98f;

    public bool isCarTypeSedan = false;

    public bool hasFrontEngine = true;

    public GameObject dynTextComp;

    public GameObject dynTextFuel;

    Text fuelStatus;

    Text inputText;

    void Start()
    {
        inputText = dynTextComp.GetComponent<Text>();

        fuelStatus = dynTextFuel.GetComponent<Text>();

        inputText.text = carModel + carMaker + engineType;

        CheckWeight();

        print (CheckCharacteristics());
        inputText.text += CheckCharacteristics();


        if (yearMade <= 2009)
        {
            inputText.text += "Car was introduced in " + yearMade;
            print("Car was introduced in " + yearMade);
            int carAge = CalculateAge();
            inputText.text += "The car is " + carAge + " years old. ";
            print("The car is " + carAge + " years old. ");
        }
        else
        {
            inputText.text += "Car was introduced in the 2010's. ";
            print("Car was introduced in the 2010's. ");
            inputText.text += "It's max acceleration is " + maxAcceleration;
            print("It's max acceleration is " + maxAcceleration);
        }
    }
   
    void Update()
    {

    }
  
    public void ConsumeFuel()
    {
        carFuel.fuelLevel = carFuel.fuelLevel - 10;
    }
   
    public void CheckFuelLevel()
    {
        switch(carFuel.fuelLevel)
        {
            case 70:
                fuelStatus.text = "fuel level is nearing two-thirds.";
                print("fuel level is nearing two-thirds.");
                break;
            case 50:
                fuelStatus.text = "fuel level is at half amount.";
                print("fuel level is at half amount.");
                break;
            case 10:
                fuelStatus.text = "Warning! Fuel level is critically low.";
                print("Warning! Fuel level is critically low.");
                break;
            default:
                fuelStatus.text = "Nothing to report.";
                print("Nothing to report");
                break;
        }
    }
   
    void CheckWeight()
    {
        if (carWeight < 1500)
        {
            inputText.text += carModel + "weighs less than 1500kg. ";
            print(carModel + " weighs less than 1500kg. ");
        }
        else 
        {
            inputText.text += carModel + "weighs over 1500kg. ";
            print(carModel + " weighs over 1500kg. ");
        }                
    }
   
    string CheckCharacteristics()
    {
        if (isCarTypeSedan)
        {
            return("Car type is sedan! ");
        }

        else if (hasFrontEngine)
        {
            return ("Not sedan, but has a front engine. ");
        }

        else
        {
            return ("Is not sedan and doesn't have a front engine. ");
        }
    }

    int CalculateAge()
    {        
        return 2021 - yearMade;
    }

}
