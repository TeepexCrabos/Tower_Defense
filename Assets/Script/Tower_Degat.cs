using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower_Degat : MonoBehaviour
{
    
    public CircleCollider2D col;
    public float spawnCooldown;
    private float timeUntilSpawn = 0;
    public GameObject tower;
    // Start is called before the first frame update
    void Update()
    {
        timeUntilSpawn -= Time.deltaTime;
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy" && timeUntilSpawn <= 0)
        {
            col.gameObject.GetComponent<Enemy_Life>().hp-= 1;
            
            timeUntilSpawn = spawnCooldown;
        }

    }
    
    void OnColliderStay2D(Collider2D col)
    {

        if(col.gameObject.tag == "tower")
        {
            Destroy(this);
        }
    }
}
