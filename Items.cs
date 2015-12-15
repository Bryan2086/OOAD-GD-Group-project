using UnityEngine;
using System.Collections;

public class Items : MonoBehaviour {
    private int healAmount;
    private string name;

    public Items(int healAmount, string name) {
        this.healAmount = healAmount;
        this.name = name;
    }

    public void setHealAmount(int heal) { healAmount = heal; }
    public int getHealAmount() { return healAmount; }

    public string getName() {
        return name;
    }
}
