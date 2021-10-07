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

        print("The vehicle is " + carModel + ". It has " + engineType);

        CheckWeight();


        if (yearMade < = 2009)
        {
            print("The vehicle was introduced in " + yearMade)

            int carAge = CalculateAge(yearMade);
            print("The vehicle is " + carAge + " years old.");

        }

        else
        {
            print("The vehicle was introduced in 2010.")
            print("The vehicle's maximum acceleration is " + maxAcceleration)
        }



    }


    void CheckWeight()
    {
      if(carWeight < 1500)

        {
            print("The " + carModel + " weights less than 1500kg");
        }
       
      else

        {
            print("The " + carModel + " weights more than 1500kg");
        }
    }



    int CalculateAge(int yearMade)

    {
        return 2021 - yearMade;
    }




    // Update is called once per frame
    void Update()
    {
       
    }
}
