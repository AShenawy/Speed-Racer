using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    public string carMaker;
    public string carModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";

    public int carWeight = 1609;
    public int yearMade = 2006;

    public float maxAcceleration = 0.98f;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;

    // Start is called before the first frame update
    void Start()
    {
        print("The racer moldes is " + carModel + ". It has a " + engineType + "engine.");
        
        CheckWeight();

        if (yearMade >= 2009)
        {
            print(carModel + "was first introduced in " + yearMade);
            int carAge = CalculateAge(yearMade);
            print("This car is " + carAge + " years old.");

        } else
        {
            print(carModel + "was introduced in the 2010's".);
            print("Its maximum acceleration is " + maxAcceleration + "m/s2");
        }

        print(CheckCharacteristics());
    }

    void CheckWeight()
    {
        if (carWeight < 1500)
        {
            print("The " + carModel + " weight less than 1500 kg.");
        }     
        else 
        {
            print("The " + carWeight + " weights over 1500 kg.");
        }
    }

    int CalculateAge(int yearMade)
    {
        return 2021 - yearMade;
    }

    // Update is called once per frame
    string CheckCharacteristics()
    {
       if (isCarTypeSedan)
       {
            return "Car type is sedan.";

       } else if (hasFrontEngine)
       {
              return "The car is not a sedan, but has a front engine.";
       } else
       {
              return "The car is neither a sedan nor its engine is a front.";
       }
    }
}
