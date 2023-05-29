using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    [SerializeField]
    public TMP_Text health;
    public TMP_Text ingrediences;
    private int[] foundObjects = {4,5,6,7};
    public TMP_Text ketchup_splash;



    private bool looseHealth()
    {
        if (health.text ==  "<sprite=0><sprite=1><sprite=2>")
        {
            health.text =  "<sprite=0><sprite=1>";
            return false;
        } 
        else if (health.text ==  "<sprite=0><sprite=1>")
        {
            health.text = "<sprite=0>";
            return false;
            }
        else
        {
            return true;
            }
    }

    private bool ingredience(string ingredience)
    {
        if (ingredience == "tomato"){
            foundObjects[0] = 0;
        }
        if (ingredience == "garlic"){
            foundObjects[1] = 1;
        }
        if (ingredience == "mushroom"){
            foundObjects[2] = 2;
        }
        if (ingredience == "yogurt"){
            foundObjects[3] = 3;
        }

        ingrediences.text = ("<sprite="+foundObjects[0]+ "><sprite=" + foundObjects[1] + "><sprite=" + foundObjects[2] + "><sprite=" + foundObjects[3]+ ">");
        
        if ((foundObjects[0] ==  0) && (foundObjects[1] ==  1) && (foundObjects[2] ==  2) && (foundObjects[3] ==  3)){
            return true;
        }
        else{
            return false;
        }
        }
        
    
    private void k_splash(bool OnOff)
    {
        if (OnOff == true){
            ketchup_splash.text = "<sprite=0>";
        }
        else{
            ketchup_splash.text = "";
        }
        }
    }

    
    

