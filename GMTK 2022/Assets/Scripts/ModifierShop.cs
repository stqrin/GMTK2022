using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ModifierShop : MonoBehaviour
{
    public Text hardTxt;
    public Text mediumTxt;
    public Text easyTxt;
    public GameObject Modifier;
    public GameObject MainMenuUI;
    private int hardAmount, mediumAmount, easyAmount;
    private bool isSettings;

    void Start()
    {
        mediumTxt.text = "Medium \nReward: 3 Coins \nAmount: " + 0;
        easyTxt.text = "Easy \nReward: 1 Coins \nAmount: " + 0;
    }


    public void HardModifier()
    {
        hardAmount++;
        hardTxt.text = "Hard \nReward: 5 Coins \nAmount: " + hardAmount;
        // hard mod

    }

    public void MediumModifier()
    {
        // medium mod
        mediumAmount++;
        mediumTxt.text = "Medium \nReward: 3 Coins \nAmount: " + mediumAmount;


    }

    public void EasyModifier()
    {
        // easy modifier
        easyAmount++;
        easyTxt.text = "Easy \nReward: 1 Coins \nAmount: " + easyAmount;
    }

    public void checkCoins()
    {

    }

    public void Reset()
    {
        easyAmount = -1;
        EasyModifier();
        mediumAmount = -1;
        MediumModifier();
        hardAmount = -1;
        HardModifier();
        
    }

   
    
}
