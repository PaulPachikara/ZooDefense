using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public GameObject endPoint;
    public HealthBar healthbar;
    public int damageDone;
    // Start is called before the first frame update
    void Start()
    {
        print("hit");
    }

    // Update is called once per frame
    void Update()
    {
        if (endPoint.transform.position == this.transform.position)
        {
            print("hit");
            Destroy(this.gameObject);
            healthbar.subtractHealth(damageDone);
        }
    }
}
