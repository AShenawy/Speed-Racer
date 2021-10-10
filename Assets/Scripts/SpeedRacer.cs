using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    string carModel = "GTR R35";
    string engineType = "V6, Twin Turbo";
    /*
    int carWeight = 1609;
    int yearMade = 2009;
    */
    int carWeight = 1609;
    int yearMade = 2009;

    float maxAcceleration = 0.98f;
    bool isCarTypeSedan = false;
    bool hasFrontEngine = true;

    /*
    float maxAcceleration = 0.98f;
    bool isCarTypeSedan = false;
    bool hasFrontEngine = true;
    */

    // Start is called before the first frame update
    void Start()
    {
        /*yearMade = 2009;
        maxAcceleration = 0.98f;
        isCarTypeSedan = false;
        hasFrontEngine = true;*/

        print(carModel);
        print(engineType);

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
            print("The carModel weighs less than 1500 kg.");
        }
            else
        {
            print("The carModel weighs over than 1500 kg.");
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
            return "Car Type i Sedan";
        else if (hasFrontEngine)
            return "the car isn’t a sedan, but has a front engine";
        else
            return "that the car is neither a sedan nor does it have a front engine";
        }


        // Update is called once per frame
    void Update()
        {

        }
    }
