using UnityEngine;
using UnityEngine.UI;

public class SpeedRacer : MonoBehaviour
{
    public string carModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";
    public int carWeight = 1609;
    public int yearMade = 2009;
    public float maxAcceleration = 0.98f;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;
    public string carMaker; 

    private string msg;
    public Text showText;
    public Text showFuelText;
    public Text showLevelText;

    public class Fuel
    {
        public int fuelLevel;

        //Constructor
        public Fuel(int amount)
        {
            fuelLevel = amount;
        }
    }

    public Fuel carFuel = new Fuel(100);


    // Start is called before the first frame update
    void Start()
    {
        //set initial value for msg
        msg = "The model specs: " + carModel + carMaker + engineType + "\n";

        msg = msg + CheckWeight();

        if (yearMade <= 2009)
        {
            msg = msg + "The car was introduced in " + yearMade + "\n";
            int carAge = CalculateAge(yearMade);
            msg = msg + "The car's age is " + carAge + "\n";
        }
        else
        {
            msg = msg + "The car was introduced in the 2010's\n";
            msg = msg + "The car's maximum acceleration is " + maxAcceleration + "\n";
        }
        msg = msg + CheckCharacteristics() + "\n";
        showTextToScreen (showText, msg);
    }

    string CheckWeight()
    {
        if (carWeight < 1500)
        {
            print(carModel + " weighs less than 1500 kg");
        }
        else
        {
            print(carModel + " weighs over 1500 kg");
        }
    }

    int CalculateAge(int year)
    {
        int result = 2021 - year;
        return result;
    }

    string CheckCharacteristics ()
    {
        if (isCarTypeSedan == true)
        {
            return ("The car is sedan");
        }
        else if (hasFrontEngine == true)
        {
            return ("The car is not a sedan, but has a front engine");
        }
        else
        {
            return ("The car is neither a sedan nor does it have a front engine");
        }
    }

    void ConsumeFuel()
    {
        string mess;
        if (carFuel.fuelLevel >= 10)
        {
            carFuel.fuelLevel = carFuel.fuelLevel-10;
            mess = "Fuel level now: " + carFuel.fuelLevel.ToString();
            showTextToScreen (showFuelText, mess);
        }
        
    }

    void CheckFuelLevel()
    {
        string msgs;
        switch (carFuel.fuelLevel)
        {
            case 70:
                msgs = "Fuel level is nearing two-thirds.";
                //print ("Fuel level is nearing two-thirds.");
                break;
            case 50:
                msgs = "Fuel level is at half amount.";
                //print ("Fuel level is at half amount.");
                break;
            case 10:
                msgs = "Warning! Fuel level is critically low.";
                //print ("Warning! Fuel level is critically low.");
                break;
            case 0:
                msgs = "You're running out of fuel!";
                break;
            default:
                msgs = "I dunno what to say";
                //print ("I dunno what to say");
                break;
        }
        showTextToScreen (showLevelText, msgs);
    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);

        if (down)
        {
            ConsumeFuel();
            CheckFuelLevel();
        }
    }

    void showTextToScreen (Text screenText, string pesan)
    {
        screenText.text = pesan;
    }


}
