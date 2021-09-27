using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QG_Life : MonoBehaviour
{
    public GameObject QG;
    public int hp;
    public BoxCollider2D col;
    public GameManager manager;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Start()
    {
        hp = 3;
    }

    void Update()
    {
        if(hp <= 0)
        {
            manager.GameOver();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            hp -= 1;

        }
    }
}
