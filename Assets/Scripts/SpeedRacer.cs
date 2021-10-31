using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpeedRacer : MonoBehaviour
{
    public string carMaker;

    public string carModel = "GTR R35";

    public string engineType = "V6, Twin Turbo";

    public int carWeight = 1609;

    public int yearMade = 2009;

    public float maxAcceleration = 0.98f;

    public bool isCarTypeSedan = false;

    public bool hasFrontEngine = true;

    public Fuel carFuel = new Fuel(100);

    public Text CarSpecificationText;

    public Button CheckFuelBtn;

    public SpeedRacer() {}

    //A class that holds all properties and function of the car's fuel tank
    public class Fuel
    {
        //private property
        int fuelLevel;

        public Text FeedbackText;

        public Fuel(int amount)
        {
            fuelLevel = amount;
        }

        //public property accessors
        public int getFuelLevel() => fuelLevel;

        public void setFuelLevel(int amount) => fuelLevel = amount;


        //updates fuel level based on car fuel consumption
        public void ConsumeFuel()
        {
            fuelLevel -= 10;
        }

        //notifies client on specific fuel level  
        public void CheckFuelLevel()
        {
            switch (fuelLevel)
            {
                case 70:
                    FeedbackText.text = "fuel level is nearing two - thirds.";
                    break;

                case 50:
                    FeedbackText.text = "fuel level is at half amount";
                    break;

                case 10:
                    FeedbackText.text = "Warning! Fuel level is critically low.";
                    break;

                default:
                    FeedbackText.text = "There is nothing to report.";
                    break;
            }
        }
    }

    // Start is called before the first frame updsate
    void Start()
    {
        CarSpecificationText = GameObject.Find("CarSpecText").GetComponent<Text>();

        CheckFuelBtn = GameObject.Find("CheckFuelBtn").GetComponent<Button>();

        carFuel.FeedbackText = GameObject.Find("feedbackText").GetComponent<Text>();

        CarSpecificationText.text += $"\nThe car model is {carModel}, {carMaker} car, with a {engineType} engine type";

        CheckFuelBtn.onClick.AddListener(MoveCar);

        //check car's weight
        CheckWeight();

        //checking if car was introduced after 2010
        if(yearMade <= 2009)
        {
            int carAge = CalculateAge(yearMade);

            CarSpecificationText.text += $"\nThis car was made in the year {yearMade}";

            CarSpecificationText.text += $"\nThis car is {carAge} years old";
        }
        else
        {
            CarSpecificationText.text += "\nThis car was probably introduced in the 2010s";

            CarSpecificationText.text += $"\nThis car has a maximum acceleration of {maxAcceleration}, woo crazy fast / slow, I dunno!";
        }

        CarSpecificationText.text += $"\n{CheckCharacteristics()}";
    }

    void MoveCar()
    {
        carFuel.ConsumeFuel();
        carFuel.CheckFuelLevel();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            carFuel.ConsumeFuel();
            carFuel.CheckFuelLevel();
        }
    }

    //checks the car weight 
    void CheckWeight()
    {
        int maxWeight = 1500;

        if (carWeight < maxWeight)
        {
            CarSpecificationText.text += $"\nCar weight is less than {maxWeight}kg";
        }
        else
        {
            CarSpecificationText.text += $"\nCar weighs over {maxWeight}kg";
        }
    }

    //calculates the age of the car
    int CalculateAge(int yearMade)
    {
        return 2021 - yearMade;
    }

    string CheckCharacteristics()
    {
        if (isCarTypeSedan) return "This is a Sedan Car";

        if (hasFrontEngine) return "This isn't a Sedan Car, but it does have a front engine hm..";

        return "This Car isn't a Sedan and doesn't have a front engine";
    }
}
