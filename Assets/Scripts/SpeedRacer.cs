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
        print(carModel + engineType);

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



    // Update is called once per frame
    void Update()
    {
       
    }
}
