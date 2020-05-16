using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public HealthBar healthbar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hit");
        //if(collision.collider.tag == "Enemy")
        //{
        //    Debug.Log("Collided with Enenmy");
        //}
    }
}
