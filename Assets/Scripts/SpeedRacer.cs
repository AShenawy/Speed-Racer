/*
 * Instructor: Ahmed Alshenawy
 * Developer: Mohammed Ockba
 * Homework 0.4.1 Creating a user interface for the SpeedRacer Game 
 * Course Basics of Game Development
 */
using UnityEngine;
using UnityEngine.UI;


public class SpeedRacer : MonoBehaviour
{
    //variables for HW#2
    public Button fuelButton;
    
    //display general info
    public GameObject displayInfoPanel;
    public Text displayInfoText;
    
    //dispaly fuel warning info
    public GameObject fuelInfoPanel;
    public Text fuelInfoText;
    
    //dispaly fuel level info
    public GameObject fuelLevelPanel;
    public Text fuelLevelText;

    //variable declaration A3.2
    public string carMaker;

    //variable declaration A3.1
    public string carModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";
    public int carWeight = 1609;
    public int yearMade = 2009;
    public float maxAcceleration = 0.98f;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;

    //Declare class Fuel to store the fuel levels
    public class Fuel
    {
        public int fuelLevel;

        //Default constructor
        public Fuel(int amount)
        {
            fuelLevel = amount;
        }

    }

    //Declare a variable of type Fuel
    public Fuel carFuel = new Fuel(100);

    // Start is called before the first frame update
    void Start()
    {
        string message;
        //print car model and engine type
        message = "The racer model is " + carModel + " " + carMaker + ".\nIt has a " + engineType + " engine.\n";
        message += CheckWeight();
        if(yearMade <= 2009)
        {
            message +=  "It was first introduced in " + yearMade;
            int age = CalculateAge(yearMade);
            message +=  "That makes it " + age + " years old";
        }
        else
        {
            message += "The car was introduced in the 2010’s.\n";
            message += "The car’s maximum acceleration is " + maxAcceleration + "m/s2\n";

        }
        message += CheckCharacteristics();

        TextToUI(displayInfoText,message);
    }

    // Update is called once per frame
    void Update()
    {
        //The action gets activated if you press on the space bar
        if (Input.GetKeyDown("space"))
        {
            PlayOneTurn();
        }
    }

    //This function can be called by either using the space bar or clicking on the accelerate button
    public void PlayOneTurn()
    {
        ConsumeFuel();
        CheckFuelLevel();
    }

    //Check if weight of the car is less or more than 1500
    string CheckWeight()
    {
        if (carWeight < 1500)
            return "the " + carModel + " weighs less than 1500 kg.\n";
        else
            return "the " + carModel + " weighs over 1500 kg.\n";
    }

    //Calculate the age of the car from the current year 2021
    int CalculateAge(int year)
    {
        return 2021 - year;
    }

    //Check if the car is sedan or not
    string CheckCharacteristics()
    {
        if(isCarTypeSedan)
            return "The car type is a sedan.\n";
        else
        {
            if (hasFrontEngine)
            {
                return "The car isn’t a sedan, but has a front engine.\n";
            }
            else
                return "The car is neither a sedan nor does it have a front engine.\n";
        }
    }
    
    void ConsumeFuel() 
    {
        //check if fuel level reached zero stop
        if (carFuel.fuelLevel > 0)
        {
            //every time we invoke the function the level of fuel will be reduced by 10
            carFuel.fuelLevel -= 10;
            TextToUI(fuelLevelText,"Current Fuel Level: " + carFuel.fuelLevel.ToString());
        }
        else
            TextToUI(fuelLevelText, "Out of Fuel!!");
    }

    void CheckFuelLevel()
    {
        string message;
        switch(carFuel.fuelLevel)
        {
            case 100:
                message = "Fuel level is Full.";
                break;
            case 70:
                message =  "Fuel level is nearing two - thirds.";
                break;
            case 50:
                message = "Fuel level is at half amount.";
                break;
            case 10:
                message = "Warning! Fuel level is critically low.";
                break;
            default:
                message = "There’s nothing to report.";
                break;

        }
        TextToUI(fuelInfoText,message);
    }

    //universal printing function pass the message and the Text container
    void TextToUI(Text textObject, string message)
    {
        //displayInfoPanel.SetActive(true);
        textObject.text = message;
    }

}
