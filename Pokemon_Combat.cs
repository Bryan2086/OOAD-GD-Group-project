using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pokemon_Combat : MonoBehaviour {


    public GameObject player;
    public GameObject pokemon;
    public GameObject enemyPokemon;
    public int damage = 30;
    public Text text;
    public float timer = 0;
    public float botTimer = 0;
    public bool yourTurn;

    public Button attack, heal, retreat, useItem, revive;
    public 
    // Use this for initialization
    void Start () {

        revive.gameObject.active = false;
        pokemon = GameObject.FindGameObjectWithTag("pokemon");

        if (this.gameObject.tag.Equals("pokemon"))
        { yourTurn = true; }
        else
        { yourTurn = false; }
	}
	
	// Update is called once per frame
	void Update () {

        

        if (this.gameObject.tag.Equals("enemy_pokemon") && yourTurn == true)
        {
            botTimer += Time.deltaTime;
            if (botTimer > .5f) { Attack(damage); }      
        }
            
	}

    public void Attack(int dmg) {
        if (yourTurn == true && this.GetComponent<Pokemon_Health>().getHealth() > 0)
        { enemyPokemon.SendMessage("TakeDamage", dmg);
          yourTurn = false;
          enemyPokemon.GetComponent<Pokemon_Combat>().setYourTurn();
          botTimer = 0;
        }
        
    }

        
 

    public void UsePotion(string name)
    {
        if (yourTurn == true)
        {
            text.text = "";
            revive.gameObject.active = false;
            player.SendMessage("RemoveItem", name);
            yourTurn = false;
            enemyPokemon.GetComponent<Pokemon_Combat>().setYourTurn();
            botTimer = 0;
        }
       
    }

    public void Retreat() {
        text.text = "You Retreated";
        
        Application.LoadLevel(0); 
        

    }


    private void EndBattle() {
       int pokemonHealth = pokemon.GetComponent<Pokemon_Health>().getHealth();
       int enemyPokemonHealth = enemyPokemon.GetComponent<Pokemon_Health>().getHealth();

        if (pokemonHealth > enemyPokemonHealth && this.gameObject.tag.Equals("pokemon")) { text.text = "You Won ! ! !"; }

        else if (player.GetComponent<Player_Inv>().HaveRevive()) {
            text.text = "USE A REVIVE POTION";
            revive.gameObject.active = true;
        }

        else{ text.text = "You Lost . . ."; }

        timer += Time.deltaTime;
        if (timer > 3) { Application.LoadLevel(0); }
   }

    private void setYourTurn()
    {
        yourTurn = true;
    }
}
