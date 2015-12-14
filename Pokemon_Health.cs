using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Pokemon_Health : MonoBehaviour {

    public int health;

    public Slider enemy;
	// Use this for initialization
	void Start () {
        health = 100;
        
	}
	
	// Update is called once per frame
	void Update () {
        if (health >= 100) { health = 100; }

        enemy.value = health;

        if (health <= 0) { GameObject.FindGameObjectWithTag("pokemon").SendMessage("EndBattle"); }

	}

    public void setHealth(int hp) { health = hp; }
    public int getHealth() { return health; }

    public void TakeDamage(int dmg) { Debug.Log("dmg");health -= dmg; }
    public void UsePotion(int heal) {  health += heal; }

}
