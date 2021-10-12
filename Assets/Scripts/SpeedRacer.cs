using UnityEngine;
using System;


public class SpeedRacer : MonoBehaviour
{

    //key features

    public string carModel = "GTR35";
    public string engineType = "V6, Twin Turbo";
    public string carMaker; // variable for A03.2



    public int carWeight = 1609;
    public int yearMade = 2009;
    public double maxAcceleration = 0.98;




    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;

    /* 
    A03.2 starts:
     */

    public class Fuel
    {
        public int fuelLevel;

        public Fuel(int amount)
        {
            fuelLevel = amount;
        }
    }
    

    public Fuel carFuel = new Fuel(100);

    /* 
   The end of A03.2
    */

    // Start is called before the first frame update
    void Start()
    {

        print("Car model: " + carModel + "\nManufacturer: " + carMaker + "\nEngine type: " + engineType);

        CheckWieght();

        if(yearMade <= 2009)
        {
            print(carModel + " was made in " + yearMade);

            int carAge = CalculateAge(yearMade);

            print("So, " +carModel + " is now " + carAge + " years old!");
        }
        else
        {
            print("The car was introduced in the 2010’s");          // This information will be availbale  
            print("Maximum accerlatiosn is: " + maxAcceleration);   // only for the models built after 2010


            
        }

        print(CheckCharactiristic());
    }

    void CheckWieght()
    {
        if (carWeight < 1500)
        {
            print(carModel + "'s weight is less than 1500 kg");
        }
        else if (carWeight > 1500)
        {
            print(carModel + "'s weight is more than 1500 kg");
        }
        else
        {
            print(carModel + "'s weight is exactrly 1500 kg"); // in case if wight (is) == 1500 kg)
        }
    }

    void ConsumeFuelLevel()
    {
        carFuel.fuelLevel = carFuel.fuelLevel- 10;
    }

    void CheckFuelLevel()
    {
        switch(carFuel.fuelLevel)
        {
            case 70: print("fuel level is nearing two-thirds"); break;
            case 50: print("fuel level is at half amount"); break;
            case 10: print("Warning! Fuel level is critically low"); break;
            default: print("There’s nothing to report."); break;
        }
    }

    int CalculateAge(int yearMade)
    {
        return DateTime.Now.Year - yearMade;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ConsumeFuelLevel();
            CheckFuelLevel();
        }
       
    }

    string CheckCharactiristic()
    {

        if (isCarTypeSedan)
        {
            return "Yes it is Sedan!";
        }
        else if (hasFrontEngine)
        {
            return "The car isn’t a sedan, but has a front engine.";
        }
        else
        {

            return "The car is neither a sedan nor does it have a front engine.";
        }
    }
}
