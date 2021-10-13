using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    string carModel = "GTR R35";
    string engineType = "V6, Twin Turbo";
    int carWeight = 1609;
    int yearMade = 2009;
    float maxAcceleration = 0.98f;
    bool isCarTypeSedan = false;
    bool hasFrontEngine = true;

    // Start is called before the first frame update
    void Start()
    {
        //Message will appear in the console
        print("This car model is " + carModel + " and its engine is " + engineType);
       

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
