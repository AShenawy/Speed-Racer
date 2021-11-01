using UnityEngine;

public class SpeedRacer : MonoBehaviour
{

    // Declare and initialise the car's information

    string carModel = "GTR R3";
    string engineType = "V6, Twin Turbo";

    int carWeight = 1609;
    int yearMade = 2009;

    float maxAcceleration = 0.98f;

    bool isCarTypeSedan = false;
    bool hasFrontEngine = true;


    // Start is called before the first frame update
    void Start()
    {
        print("The racermodel is" + carModel + ". It has a " + engineType + "engine.");

        CheckWeight();
        if (yearMade <=2009
        {
            print("It was first introduced in" + yearMade);
            int carAge = calculateAge(yearMade);

            print ("That makes it " + carAge + "years old.")




        }else
        {
            print("It was introduced in the 2010's");
            print("And its maximum acceleration is" + maxAccelleration + "m/s2");

        }

        print(checkCharacteristics());
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
