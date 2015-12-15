using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Pokemon_Health : MonoBehaviour {

    public int health;
    public bool isAlive = true;

    public Slider enemy;
	// Use this for initialization
	void Start () {
        health = 100;
        
	}
	
	// Update is called once per frame
	void Update () {
        if (health >= 100) { health = 100; }

        enemy.value = health;

        if (health <= 0) { isAlive = false; }
        if (isAlive == false) { GameObject.FindGameObjectWithTag("pokemon").SendMessage("EndBattle"); }

	}

    public void setHealth(int hp) { health = hp; }
    public int getHealth() { return health; }

    private void TakeDamage(int dmg) { health -= dmg; }
    private void IncreaseHealth(int heal) {  health += heal; }

    public void setAlive()
    {
        isAlive = true;
    }

}
