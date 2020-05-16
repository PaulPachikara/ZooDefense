using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthbar;
    public MoneyBar money;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        money.setAmount(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            money.addAmount(20);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            money.subtractAmount(20);
        }
    }
}
