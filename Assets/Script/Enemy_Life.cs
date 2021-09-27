using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Life : MonoBehaviour
{
    public GameManager manager;
    public GameObject enemy;
    public int hp;
    public CircleCollider2D col;
   

    // Update is called once per frame
    void Update()
    {
        if(hp <= 0)
        {
            Destroy(enemy);
            manager.goldplus();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "QG")
        {
            Destroy(enemy);
        }

    }

    void SubirDegat()
    {
        hp -= 1;
    }
}
