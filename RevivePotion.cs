using UnityEngine;
using System.Collections;

public class RevivePotion : Items {

    public bool isAlive;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public RevivePotion(int healAmount, string name) : base (healAmount, name) { }
}
