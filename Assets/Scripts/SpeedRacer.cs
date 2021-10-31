using UnityEngine;
using UnityEngine.UI;

public class SpeedRacer : MonoBehaviour
{
    public Button fuelButton;
    public Text carStats;

    public string carModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";
    public int carWeight = 1609;
    public int yearMade = 2009;
    public float maxAcceleration = 0.98f;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;
    public string carMaker;
    private bool firstTimePressed = true;
    private string staticCarStats;

    // Start is called before the first frame update
    void Start()
    {
        string part1 = ("the racer model is " + carModel + " " + carMaker + ". It has a " + engineType + " engine.");
        string weight = CheckWeight();
        string part2;
        string part3;
        if(yearMade <= 2009)
        {
            part2 = ("the car was introduced in " + yearMade);
            int carAge = CalculateAge(yearMade);
            part3 = ("That makes it " + carAge + " years old.");
        }
        else
        {
            part2 = ("the car was introduced in the 2010’s");
            part3 = ("Car´s maxium acceleration is " + maxAcceleration);
        }

        string character = CheckCharacteristics();
        string n = "\n";
        carStats.text = part1 + n + weight + n + part2 + n + part3;
    }

    public void pressCarButton()
    {
        ConsumeFuel();
        string fuelLevel = CheckFuelLevel();
        if (firstTimePressed)
        {
            firstTimePressed = false;
            staticCarStats = carStats.text + "\n" + "\n";
        }
        carStats.text = staticCarStats + fuelLevel;
    }

    private string CheckWeight()
    {
        if (carWeight < 1500)
        {
            return ("The " + carModel + " weights less than 1500 kg.");
        }
        else
        {
            return ("The " + carModel + " weights over 1500 kg.");
        }
    }

    private int CalculateAge(int pYearMade)
    {
        return 2021 - pYearMade;
    }

    private string CheckCharacteristics()
    {
        if(isCarTypeSedan)
        {
            return "The car is a sedan.";
        }
        else
        {
            if (hasFrontEngine)
            {
                return "The car is not a sedan, but has a front engine.";
            }
            else
            {
                return "The car is neither a sedan nor does it have a front engine.";
            }
        }
    }

    private void ConsumeFuel()
    {
        carFuel.fuelLevel -= 10;
    }

    private string CheckFuelLevel()
    {
        switch (carFuel.fuelLevel)
        {
            case 10:
                {
                    return ("Warning! Fuel level is critically low.");
                }
            case 50:
                {
                    return ("fuel level is at half amount.");
                }
            case 70:
                {
                    return ("fuel level is nearing two-thirds.");
                }
            default:
                {
                    return ("there’s nothing to report.");
                }
        }
    }

    public class Fuel
    {
        public int fuelLevel;
        public Fuel(int pAmount)
        {
            fuelLevel = pAmount;
        }
    }

    Fuel carFuel = new Fuel(100);
}
