using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower_Degat : MonoBehaviour
{
    
    public CircleCollider2D col;
    public float spawnCooldown;
    private float timeUntilSpawn = 0;
    public GameObject tower;
    public RectTransform rect;
    private Vector2 screenPoint;
    public Camera cam;
    public Vector2[] tour = new Vector2[10];
    // Start is called before the first frame update


    void Update()
    {
        timeUntilSpawn -= Time.deltaTime;
        screenPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy" && timeUntilSpawn <= 0)
        {
            col.gameObject.GetComponent<Enemy_Life>().hp-= 1;
            
            timeUntilSpawn = spawnCooldown;
        }

    }

    
}
