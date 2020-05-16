using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyBar : MonoBehaviour
{
    public Text moneyText;
    public int moneyValue;

    void Start()
    {
        moneyValue = 10;
        moneyText.text = "Money: $" + moneyValue.ToString();
    }

    public void setAmount(int amount)
    {

        moneyValue = amount;
        moneyText.text = "Money: $" + moneyValue.ToString();
    }
    public void addAmount(int amount)
    {
        moneyValue += amount;
        moneyText.text = "Money: $" + moneyValue.ToString();
    }
    public void subtractAmount(int amount)
    {
        moneyValue -= amount;
        if (moneyValue < 0)
        {
            moneyValue = 0;
        }
        moneyText.text = "Money: $" + moneyValue.ToString();
    }
    //void Update()
    //{
    //    moneyText.text = moneyValue.ToString();
    //}
}
