using UnityEngine;
using UnityEngine.UI;

public class SpeedRacer : MonoBehaviour
{
    public string carMaker;
    public string carModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";
    public int carWeight = 1609;
    public int yearMade = 2009;
    public float maxAcceleration = 0.98f;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;
    public GameObject carInfo;
    public GameObject carAge;
    public GameObject fuelLevel;
    public GameObject checkWeight;
    public GameObject checkCharacteristics;
    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        string carText = "Car: " + carModel + "\n" + "Brand: " + carMaker + "\n" + "Engine: " + engineType;
        TextToUI(carInfo, carText);

        CheckWeight();
        string carAgeText;
        if (yearMade <= 2009)
        {
            int ageOfCar = CalculateAge(yearMade);
            carAgeText = "The car was introduced in " + yearMade + "\n" + "The age of the car is " + ageOfCar;
            TextToUI(carAge, carAgeText);
        }
        else
        {
            carAgeText = "The car was introduced in the 2010’s" + "\n" + "The car’s maximum acceleration is " + maxAcceleration;
            TextToUI(carAge, carAgeText);
        }
        CheckCharacteristics();
    }
    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        ConsumeFuel();
        CheckFuelLevel(); 
    }
    void ConsumeFuel()
    {
        carFuel.fuelLevel = carFuel.fuelLevel - 10;
    }
    void CheckFuelLevel()
    {
        string fuelLevelText;
        switch (carFuel.fuelLevel)
        {
            case 70:
                fuelLevelText = "fuel level is nearing two-thirds";
                TextToUI(fuelLevel, fuelLevelText);
                print(carFuel.fuelLevel);
                break;
            case 50:
                fuelLevelText = "fuel level is at half amount";
                TextToUI(fuelLevel, fuelLevelText);
                break;
            case 10:
                fuelLevelText = "Warning! Fuel level is critically low";
                TextToUI(fuelLevel, fuelLevelText);
                break;
            default:
                fuelLevelText = "there's nothing to report";
                TextToUI(fuelLevel, fuelLevelText);
                print(carFuel.fuelLevel);
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
       
    }
    void CheckWeight()
    {
        string checkWeightText;
        if (carWeight < 1500)
        {
            checkWeightText = carModel + " weighs less than 1500 kg";
            TextToUI(checkWeight, checkWeightText);
        } 
        else 
        {
            checkWeightText = carModel + " weighs over 1500 kg";
            TextToUI(checkWeight, checkWeightText);
        }
        
    }
    void TextToUI(GameObject gameObject, string editedText)
    {
        gameObject.GetComponent<Text>().text = editedText;
    }
    int CalculateAge(int yearMade)
    {
        return 2021 - yearMade;
    }
    void CheckCharacteristics()
    {
        if (isCarTypeSedan)
        {
            TextToUI(checkCharacteristics, "The car is a sedan");
        } 
        else if (hasFrontEngine) {
            TextToUI(checkCharacteristics, "The car is not sedan, but it has a front engine");
        }
        else
        {
            TextToUI(checkCharacteristics, "The car is neither a sedan nor does it have a front engine");
        }
    }
    public class Fuel
    {
        public int fuelLevel;
        public Fuel (int amount)
        {
            fuelLevel = amount;
        }
    }
    public Fuel carFuel = new Fuel(100);
}
