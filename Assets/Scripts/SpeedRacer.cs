using UnityEngine;

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

    public string carModel = " GTR R35";

    public string carMaker;

    public string engineType = " V6, Twin Turbo";

    public int carWeight = 1609;

    public int yearMade = 2009;

    public float maxAcceleration = 0.98f;

    public bool isCarTypeSedan = false;

    public bool hasFrontEngine = true;    

    void Start()
    {
        print(carModel + carMaker + engineType);

        CheckWeight();

        print (CheckCharacteristics());

        if (yearMade <= 2009)
        {
            print("Car was introduced in " + yearMade);
            int carAge = CalculateAge();
            print("The car is " + carAge + " years old");
        }
        else
        {
            print("Car was introduced in the 2010's");
            print("It's max acceleration is " + maxAcceleration);
        }
    }
   
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            ConsumeFuel();
            CheckFuelLevel();
        }
    }
  
    void ConsumeFuel()
    {
        carFuel.fuelLevel = carFuel.fuelLevel - 10;
    }
   
    void CheckFuelLevel()
    {
        switch(carFuel.fuelLevel)
        {
            case 70:
                print("fuel level is nearing two-thirds.");
                break;
            case 50:
                print("fuel level is at half amount.");
                break;
            case 10:
                print("Warning! Fuel level is critically low.");
                break;
            default:
                print("Nothing to report");
                break;
        }
    }
   
    void CheckWeight()
    {
        if (carWeight < 1500)
        {
            print(carModel + " weighs less than 1500kg");
        }
        else 
        {
            print(carModel + " weighs over 1500kg");
        }                
    }
   
    string CheckCharacteristics()
    {
        if (isCarTypeSedan)
        {
            return("Car type is sedan!");
        }

        else if (hasFrontEngine)
        {
            return("Not sedan, but has a front engine.");
        }

        else
        {
            return("Is not sedan and doesn't have a front engine.");
        }
    }

    int CalculateAge()
    {        
        return 2021 - yearMade;
    }

}
