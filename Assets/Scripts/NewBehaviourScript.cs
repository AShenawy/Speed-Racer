using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
  
    string carModel = "GTR R35";
    string engineType = "V6, Twin Turbo";
    int carWeight = 1609;
    int yearMade = 2009;
    float maxAcceleration = 40.0f;
    bool isCarTypeSedan = false;
    bool hasFrontEngine = true;
    int carAge;


    // Start is called before the first frame update
    void Start()
    {
        print(carModel + " " + engineType);
        print("previous step");
        CheckWeight();
        if (yearMade >= 2009)
        {
            print("what year the car was introduced in, using the " + yearMade);
            carAge = CalculateAge(yearMade);
            print("the age of the car" + carAge);
        }
        else
        {
            print("the car was introduced in the 2010’s");
            print("car’s maximum acceleration" + maxAcceleration);
        }

        CheckCharacteristics();


    }

    // Update is called once per frame
    void Update()
    {

    }

    void CheckWeight()
    {
        if (carWeight < 1500)
        {
            print(carModel + "less than 1500 kg ");
        }
        else
        {
            print(carModel + "over 1500 kg ");
        }
    }



    int CalculateAge(int yearMade)
    {
        return 2021 - yearMade;
    }

    string CheckCharacteristics()
    {
        if (isCarTypeSedan)
        {
            return "The car is a sedan type.";

        }
        else if (hasFrontEngine)
        {
            return "The car is not a sedan, but has a front engine.";

        }
        else
        {
            return "The car is neither a sedan, nor is its engine a front engine.";
        }
    }

}
