using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections;

public class SpeedRacer : MonoBehaviour
{

    //key features

    public string carModel = "GTR35";
    public string engineType = "V6, Twin Turbo";
    public string carMaker; // variable for A03.2




    public int carWeight = 1609;
    public int yearMade = 2009;
    public double maxAcceleration = 0.98;

    public GameObject carInfo;



    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;


    // variables for fuel level checking
    public Text numberText;
    public int number = 100;



    public Text carModelText;
    public Text carMakerText;
    public Text engineTypeText;
    public Text carWeightText;
    public Text carYearText;
    public Text carAgeText;
    public Text carIsSedanText;

    public Button myButton;

    // public GameObject carInfo; 

    /* 
    A03.2 starts:
     */

    public class Fuel
    {
        public int fuelLevel;

        public Fuel(int amount)
        {
            fuelLevel = amount;
        }
    }


    public Fuel carFuel = new Fuel(100);





    //public Text Text;



    /* 
   The end of A03.2
    */

    // Start is called before the first frame update
    void Start()
    {

        //Game View Texts
        printText(carModelText, carModel);
        printText(carMakerText, carMaker);              
        printText(engineTypeText, engineType);
        printText(carWeightText, CheckWieght());
        printText(carYearText, CheckYear());
        printText(carAgeText, CheckAge());
        printText(carIsSedanText, CheckCharactiristic());

        
        CheckWieght1(); // Function for Console View

        /*checking conditions to print on 
         *Console View
         */
        if (yearMade <= 2009)
        {
            print(carModel + " was made in " + yearMade);

            int carAge = CalculateAge(yearMade);

            print("So, " + carModel + " is now " + carAge + " years old!");
        }
        else
        {
            print("The car was introduced in the 2010’s");          // This information will be availbale  
            print("Maximum accerlatiosn is: " + maxAcceleration);   // only for the models built after 2010
        }

        print(CheckCharactiristic());// Function for Console View

    }

    void printText(Text text, string str)
    {
        if (!(str == ""))
        {
            text.text = str;
        }
        else
        {
            text.text = "No Value";
        }
    }


    // CheckWieght functions for ConsoleView
    void CheckWieght1()
    {
        if (carWeight < 1500)
        {
            print(carModel + "'s weight is less than 1500 kg");
        }
        else if (carWeight > 1500)
        {
            print(carModel + "'s weight is more than 1500 kg");

        }
        else
        {
            print(carModel + "'s weight is exactrly 1500 kg"); // in case if wight (is) == 1500 kg)
        }
    }

    // CheckWieght functions for GameView
    string CheckWieght()
    {
        if (carWeight < 1500)
        {
            return carModel + "'s weight is less than 1500 kg";
        }

        else if (carWeight > 1500)
        {
            return carModel + "'s weight is more than 1500 kg";

        }
        else
        {
            return carModel + "'s weight is exactrly 1500 kg"; // in case if wight (is) == 1500 kg)
        }
    }


    void ConsumeFuelLevel()
    {
        carFuel.fuelLevel = carFuel.fuelLevel - 10;
    }

    void CheckFuelLevel()
    {
        switch (carFuel.fuelLevel)
        {
            case 70: print("fuel level is nearing two-thirds"); break;
            case 50: print("fuel level is at half amount"); break;
            case 10: print("Warning! Fuel level is critically low"); break;
            default: print("There’s nothing to report."); break;
        }
    }

    int CalculateAge(int yearMade)
    {
        return DateTime.Now.Year - yearMade;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ConsumeFuelLevel();
            CheckFuelLevel();
        }

    }

    string CheckCharactiristic()
    {

        if (isCarTypeSedan)
        {
            return "Yes it is Sedan!";
        }
        else if (hasFrontEngine)
        {
            return "The car isn’t a sedan, but has a front engine.";
        }
        else
        {
            return "The car is neither a sedan nor does it have a front engine.";
        }
    }


    //Console View >> Game View
    public void SetText(string text)
    {
        Text txt = transform.Find("Text").GetComponent<Text>();
        txt.text = text;
    }

    string CheckYear()
    {
        return " was made in " + yearMade;
    }

    string CheckAge()
    {
        if (yearMade <= 2009)
        {
        int carAge = CalculateAge(yearMade);
        return carModel + " is now " + carAge + " years old!";
        }
        else
        {
        return "The car was introduced in the 2010’s. Maximum accerlatiosn is: " + maxAcceleration;
        }
    }

    //Fuel Level Checker

    public void ButtonClicked()
    {
        number--;
        string a = "Fuel level is: " + number.ToString();

        if (number < 60 && number > 40)
            {
                numberText.text = a + "\nAttention!! Fuel level is at half amount!!";
            }
            else if (number < 40 && number > 10)
            {
                //   print("Fuel level is: ");
                numberText.text = a + "\nWarning! Fuel level is critically low: ";
            }
            else if (number == 0)
            {
                myButton.interactable = false;
            }
            else
            {
            numberText.text = "Fuel level is: " + number.ToString();
            }
    }
}









