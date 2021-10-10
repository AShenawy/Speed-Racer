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
        print(carModel);
        print(engineType);
        CheckWeight();
 
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


    // Update is called once per frame
    void Update()
    {
       
    }
}
