using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

public class Player_Inv : MonoBehaviour {

    List<HealthPotion> list = new List<HealthPotion>();

    HealthPotion hp = new HealthPotion();

	// Use this for initialization
	void Start () {
        list.Add(hp);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void RemoveItem(){

        if (list.Contains(hp)) {
            list.Remove(hp);
            Debug.Log("inv");
            GameObject.FindGameObjectWithTag("Player").SendMessage("usePotion");
        }
    }


    public void AddItem() { list.Add(hp);  }
}
