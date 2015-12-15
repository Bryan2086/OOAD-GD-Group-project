using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine.UI;
public class Player_Inv : MonoBehaviour {

    public Text amountOfMoney;    

    public List<Items> inventory = new List<Items>();

    Items healthPotion = new HealthPotion(30, "potion", 30, 10);
    RevivePotion revive = new RevivePotion(100, "revive", 50, 12);
    private int coins = 1000;
    
   
	// Use this for initialization
	void Start () {

        //coins = PlayerPrefs.GetInt("PlayerMoney");
        inventory.Add(revive);
        inventory.Add(healthPotion);
        
    }

    // Update is called once per frame
    void Update() {
        //PlayerPrefs.SetInt("PlayerMoney", coins);
        amountOfMoney.text = "Coins: "+ coins;
        
	}
    public bool HaveRevive() {
        if (inventory.Contains(revive)) { return true; }
        else { return false; }
    }

    private void RemoveItem(string name)
    {

        if (inventory.Exists(e => e.getName().Equals(name)))
        {
            Debug.Log("REV POT");
            inventory.RemoveAll(e => e.getName().Equals(name));

            if (name.Equals("revive"))
            {
                GameObject.FindGameObjectWithTag("pokemon").SendMessage("UsePotion", revive.getHealAmount());
            }
            else  {
                GameObject.FindGameObjectWithTag("pokemon").SendMessage("UsePotion", healthPotion.getHealAmount());
            }

        }

    }



    //   }

    /*   if (name.Equals("potion"))
      {

           if (list.Exists(e => e.getName().Equals("potion")))
           {
               Debug.Log("HP POT");
               list.RemoveAll(e => e.getName().Equals("potion"));
               GameObject.FindGameObjectWithTag("pokemon").SendMessage("UsePotion", hp.getHealAmount());
           }
       }*/





    private void AddItem(string name) {
        if (name.Equals("healthPotion"))
        { 
            inventory.Add(healthPotion);
        }
        else if(name.Equals("revive"))
        {
            inventory.Add(revive);
        }
    }
    public void itemTransaction(string name)
    {
        if(name.Equals("buyHealthPotion"))
        {
            if(coins >healthPotion.getBuyValue())
            {
                coins -= healthPotion.getBuyValue();
                AddItem("healthPotion");
            }
           
        }
        if (name.Equals("buyRevive"))
        {
            if(coins > revive.getBuyValue())
            {
                coins -= revive.getBuyValue();
                AddItem("revive");
            }
           
        }
        if (name.Equals("sellHealthPotion"))
        {
            if (inventory.Exists(e => e.getName().Equals("potion")))
            {
                coins += healthPotion.getSellValue();
                RemoveItem("potion");
            }
                

        }
        if (name.Equals("sellRevive"))
        {
            if (inventory.Exists(e => e.getName().Equals("revive")))
            {
                coins += revive.getSellValue();
                RemoveItem("revive");
            }
                
        }
    }

  
}
