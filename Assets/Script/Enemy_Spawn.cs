using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Enemy_Spawn : MonoBehaviour
{
    public Vector3 newPos;
    public float spawnCooldown;
    private float timeUntilSpawn;

    public float spawnTowerCooldown;
    private float timeUntilSpawnTower;

    public GameObject PrefEnemy;
    public GameObject PrefTower;
    public GameManager manager;
    public RectTransform[] tour = new RectTransform[10];
    public int j = 0;

    public RectTransform rect;
    Vector2 vec;
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        
        newPos = new Vector3(-10.0f, 0.0f, 0.0f);
        timeUntilSpawn = 0;
        timeUntilSpawnTower = 0;
       
    }

    // Update is called once per frame
    void Update()
    {
        timeUntilSpawn -= Time.deltaTime;
        if (timeUntilSpawn <= 0)
        {
            GameObject octo = Instantiate(PrefEnemy, newPos, Quaternion.identity) as GameObject;

           timeUntilSpawn = spawnCooldown;
        }

        timeUntilSpawnTower -= Time.deltaTime;
    }

   

    void OnGUI()
    {
        Vector2 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        if (Input.GetMouseButtonUp(0) && manager.gold >= 100 && mouseWorldPos.y < -0.5 )
        {
            
            if (timeUntilSpawnTower <= 0 && j <10 )
            {
                
                manager.gold -= 100;

                GameObject autre = Instantiate(PrefTower, mouseWorldPos, Quaternion.identity) as GameObject;
                
                tour[j] = autre.GetComponent<RectTransform>();
                j = j + 1;
                timeUntilSpawnTower = spawnTowerCooldown;
            }
        }

        if (Input.GetMouseButtonUp(0) && manager.gold >= 100 && mouseWorldPos.y > 0.5 )
        {
            
            if (timeUntilSpawnTower <= 0 && j < 10 )
            {
            manager.gold -= 100;

             GameObject autre = Instantiate(PrefTower, mouseWorldPos, Quaternion.identity) as GameObject;
             timeUntilSpawnTower = spawnTowerCooldown;
             tour[j] = autre.GetComponent<RectTransform>();
             j = j + 1;
            
            }
        }
    }
   

    /*public bool verif(Vector2 mouseWorldPos)
    {
        for(int i=0;i < tour.Length; i++)
        {
            Debug.Log("Boucle verif");
            Debug.Log(rect);
            Debug.Log(tour[i]);
            
            if (RectTransformUtility.RectangleContainsScreenPoint(tour[i], mouseWorldPos, cam) == false)
            {

                Debug.Log("faux");
                return true;
          
            }
        }
        Debug.Log("vrai");
        return false;
    }*/
}
