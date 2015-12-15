using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

public class Player_Inv : MonoBehaviour {

    public List<Items> list = new List<Items>();

    HealthPotion hp = new HealthPotion(30, "potion");
    RevivePotion rev = new RevivePotion(100, "revive");

	// Use this for initialization
	void Start () {
        list.Add(rev);
        list.Add(hp);
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public bool HaveRevive() {
        if (list.Contains(rev)) { return true; }
        else { return false; }
    }

    private void RemoveItem(string name){

        if (name.Equals("revive"))
        {

            if (list.Exists(e => e.getName().Equals("revive")))
            {
                Debug.Log("REV POT");
                list.RemoveAll(e => e.getName().Equals("revive"));
                GameObject.FindGameObjectWithTag("pokemon").SendMessage("UsePotion", rev.getHealAmount());
            }
        }

        if (name.Equals("potion"))
        {

            if (list.Exists(e => e.getName().Equals("potion")))
            {
                Debug.Log("HP POT");
                list.RemoveAll(e => e.getName().Equals("potion"));
                GameObject.FindGameObjectWithTag("pokemon").SendMessage("UsePotion", hp.getHealAmount());
            }
        }

      
    }


    private void AddItem() { list.Add(hp);  }
}
