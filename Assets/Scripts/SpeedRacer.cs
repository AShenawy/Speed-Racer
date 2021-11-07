using UnityEngine;

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
        msg = "The model specs: " + carModel + carMaker + engineType + "\n";
        print(carModel + carMaker + engineType);

        CheckWeight();

        if (yearMade <= 2009)
        {
            print("The car was introduced in " + yearMade);
            int carAge = CalculateAge(yearMade);
            print("The car's age is " + carAge);
        }
        else
        {
          print("The car was introduced in the 2010's");
          print("The car's maximum acceleration is " + maxAcceleration);
        }
         print(CheckCharacteristics());
    }

    void CheckWeight()
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
        carFuel.fuelLevel = carFuel.fuelLevel-10;
    }

    void CheckFuelLevel()
    {
        switch (carFuel.fuelLevel)
        {
            case 70:
                print ("Fuel level is nearing two-thirds.");
                break;
            case 50:
                print ("Fuel level is at half amount.");
                break;
            case 10:
                print ("Warning! Fuel level is critically low.");
                break;
            default:
                print ("I dunno what to say");
                break;
        }

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


}
