using UnityEngine;
using System.Collections;

public class Items : MonoBehaviour {
    private int healAmount;
    private string name;
    private int buyValue;
    private int sellValue;

    public Items(int healAmount, string name, int buyValue, int sellValue) {
        this.healAmount = healAmount;
        this.name = name;
        this.buyValue = buyValue;
        this.sellValue = sellValue;
    }

    public void setHealAmount(int heal) { healAmount = heal; }
    public int getHealAmount() { return healAmount; }

    public void setBuyValue(int buyValue) { this.buyValue = buyValue; }
    public int getBuyValue()
    {
        return buyValue;
    }
    public void setValue(int value) { this.sellValue = value; }
    public int getSellValue()
    {
        return sellValue;
    }

    public string getName() {
        return name;
    }
}
