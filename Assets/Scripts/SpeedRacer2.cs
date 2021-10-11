using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    public string carModel = "GTR R35";
    public string carMaker;
    public string engineType = "V6, Twin Turbo";
    public int carWeight = 1609;
    public int yearMade = 2009;
    public float maxAcceleration = 0.98f;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;

    //Subclass for fuel information
    public class Fuel
    {
        //Declare an integer variable
        public int fuelLevel;

        //Create amount parameter
        public Fuel(int amount)
        {
            fuelLevel = amount;
        }

    }

    //Passing a value to the previous constructor
    public Fuel carFuel = new Fuel(100);


    // Start is called before the first frame update
    void Start()
    {
        //Message will appear in the console
        print("This car model is " + carModel);
        print("The engine is " + engineType);

        //Call weight function, if statement
        CheckWeight();

        //Check if year is appropriate
        //If the year is less or equal to 2009
        if (yearMade <= 2009)
        {
            //...do this
            print("The " + carModel + " was introduced in " + yearMade);

            //Call the calculate age function
            int carAge = CalculateAge(yearMade);

            print("which means it is " + carAge + " years old");
        }
        //If the year is more than 2009
        else if (yearMade > 2009)
        {
            //...do this
            print(carModel + " was introduced in 2010");
            print(carModel + "'s maximum acceleration is" + maxAcceleration + "m/s");
        }

        print(CheckCharacteristcs());
    }



    //If statement influenced by spacebar press
    void Update()
    {
        //Namethe key pressed
        //Call the functions implied in if statement
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ConsumeFuel();
            CheckFuelLevel();
        }
    }


    void ConsumeFuel()
    {
        //Substract 10 from old fuel value
        carFuel.fuelLevel = carFuel.fuelLevel - 10;
    }

    //Statement that checks the fuel level 
    void CheckFuelLevel()
    {
        switch (carFuel.fuelLevel)
        {
            //Print message in case fuel level is 70
            case 70:
                print("Fuel level is nearing two - thirds.");
                break;
            //Print message in case fuel level is 50
            case 50:
                print("Fuel level is at half amount.");
                break;
            //Print message in case fuel level is 10
            case 10:
                print("Warning! Fuel level is critically low.");
                break;
            //Print message in case fuel level is 0
            case 0:
                print("No fuel! In romanian we would call this: pana prostului");
                break;
            //Print message in case fuel level is none of the above
            default:
                print("nothing to report here...");
                break;
        }
    }


    //Function that prints message if the weight is under or over 1500
    void CheckWeight()
    {
        //If the car weight is smaller than 1500...
        if (carWeight < 1500)
        {
            //...do this
            print(carModel + " weights less than 1500kg");
        }
        //If the car weight is bigger than 1500...
        else
        {
            //...do this
            print(carModel + " weights more than 1500kg");
        }
    }

    //Function that calculates age
    int CalculateAge(int yearMade)
    {
        return 2021 - yearMade;
    }

    //Function that checks characteristics based on car type and engine I don't understand because I don't like cars
    string CheckCharacteristcs()
    {
        if (isCarTypeSedan)
        {
            return "The car type is sedan";
        }
        else if (hasFrontEngine)
        {
            return "Apparently the car isn't a sedan, but has a nice front engine";
        }
        else
        {
            return "Unfortunately, it isn't sedan and it doesn't have a front engine";
        }
    }

}
