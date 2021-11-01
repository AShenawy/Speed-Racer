using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickButton : MonoBehaviour
{
    //public string fueltext;

    public Button myButton;
    public Text outputFuel;
    
    public void TaskOnClick()
    {
        //Debug.Log("You have clicked the button!");
        ConsumeFuel();
        CheckFuelLevel();

        outputFuel.text = "check";
    }
    
    public void seeText(string text)
     {
         outputFuel.text = text;
     }

    public class Fuel
    {
        public int fuelLevel;
        //Constructor
        public Fuel(int amount)
        {
            fuelLevel = amount;
        }
    } 

    public Fuel carFuel = new Fuel(100);

    public void ConsumeFuel()
    {
        carFuel.fuelLevel = carFuel.fuelLevel - 10;
    }

    public void CheckFuelLevel()
    {

        switch (carFuel.fuelLevel)
        {
            case 70:
                print("fuel level is nearing two-thirds");
                
                break;
            case 50:
                print("fuel level is at half amount");
                
                break;
            case 10:
                print("Warning! Fuel level is critically low");
                
                break;
            default:
                print("there's nothing to report");
         
                break;

        }

    }

}
    

