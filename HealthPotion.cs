using UnityEngine;
using System.Collections;

public class HealthPotion : MonoBehaviour {

    public int healAmount;
	// Use this for initialization
	void Start () {
        healAmount = 40;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void usePotion() { Debug.Log("hp"); GameObject.FindGameObjectWithTag("pokemon").SendMessage("UsePotion", healAmount); }
}
