using UnityEngine;
using System.Collections;

public class HealthPotion : Items {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public HealthPotion(int healAmount, string name) : base (healAmount, name) { }

    //private void usePotion() { GameObject.FindGameObjectWithTag("pokemon").SendMessage("UsePotion", this.getHealAmount()); }
}
