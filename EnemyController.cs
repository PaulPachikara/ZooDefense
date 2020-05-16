using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int health;
    public int damageDone;
    public HealthBar healthbar;
    public HealthBar enemyHealthBar;
    public int moneyRewarded;
    public GameObject endPoint;
    public MoneyBar moneyBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (endPoint.transform.position == this.transform.position)
        {
            Destroy(this.gameObject);
            healthbar.subtractHealth(damageDone);
        }
        if (health <= 0)
        {
            Destroy(this.gameObject);
            moneyBar.addAmount(moneyRewarded);
        }
    }
    public void TakeDamage(int damage)
    {
        this.health -= damage;
        enemyHealthBar.subtractHealth(damage);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Tower")
        {
            this.TakeDamage(10);
        }
    }
}
