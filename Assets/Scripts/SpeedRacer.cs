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

    public class Fuel
    {
        public int fuelLevel;

        //Constructor
        public Fuel(int amount)
        {
            fuelLevel = amount;
        }
    }
    // how to see if it's even work 

    public Fuel carFuel = new Fuel(100);

    // several constructors, how parameters match?

    void ConsumeFuel()
    {
        carFuel.fuelLevel = carFuel.fuelLevel - 10;
    }

    void CheckFuelLevel()
    {
        switch (carFuel.fuelLevel)
        {
            case 70:
                print("fuel level is nearing two-thirds");
                break;
            case 50:
                print("fuel level is at half amount");
                break;
            case 10:
                print("Warning! Fuel level is critically low");
                break;
            default:
                print("there’s nothing to report");
                break;

        }

    }

    // Start is called before the first frame update
    void Start()
    {
        print(carModel+carMaker+engineType);

        //Debug.Log(carModel);
        //Debug.Log(engineType);

        CheckWeight();

        /*CalculateAge(yearMade); for ¹ 3 
         * yearMade = CalculateAge(yearMade); 
        Debug.Log(yearMade); print result ¹ 3
        */

        //int CheckyearMade(int yearMade)

        if (yearMade <= 2009)
        {
            print(yearMade);
            int carAge = CalculateAge(yearMade);
            print(carAge);
        }
        else
        {
            print("the car was introduced in the 2010’s");
            print("the car’s maximum acceleration"+maxAcceleration);
        }

        print(CheckCharacteristics());
        
    }

    void CheckWeight()
    {
        if (carWeight < 1500)
        {
            print(carModel+"weighs less than 1500 kg.");
        }
        else
        {
            print(carModel+"weighs over than 1500 kg.");
        }
    }

    int CalculateAge(int yearMade)
    {
        int result;
        result = 2021 - yearMade;
        return result;
    }

    string CheckCharacteristics()
    {
        if (isCarTypeSedan)
        {
            return "Car Type i Sedan";
        }
        else if (hasFrontEngine)
        {
            return "the car isn’t a sedan, but has a front engine";
        }
        else
        {
            return "that the car is neither a sedan nor does it have a front engine";
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
