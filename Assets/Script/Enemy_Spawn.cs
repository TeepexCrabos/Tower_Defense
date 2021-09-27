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


        if (Input.GetMouseButtonUp(0) && !EventSystem.current.IsPointerOverGameObject() && manager.gold >= 100 && mouseWorldPos.y < -0.5)
        {
            
            if (timeUntilSpawnTower <= 0)
            {
                manager.gold -= 100;
                Event currentEvent = Event.current;
                Vector2 mousePos = new Vector2();
                Vector3 point = new Vector3();


                mousePos.x = currentEvent.mousePosition.x;
                mousePos.y = GetComponent<Camera>().pixelHeight - currentEvent.mousePosition.y;
                point = GetComponent<Camera>().ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 0.0f));

                GameObject autre = Instantiate(PrefTower, mouseWorldPos, Quaternion.identity) as GameObject;
                timeUntilSpawnTower = spawnTowerCooldown;
            }
        }
        if (Input.GetMouseButtonUp(0) && !EventSystem.current.IsPointerOverGameObject() && manager.gold >= 100 && mouseWorldPos.y > 0.5)
        {
            
            if (timeUntilSpawnTower <= 0)
            {
            manager.gold -= 100;
            Event currentEvent = Event.current;
            Vector2 mousePos = new Vector2();
            Vector3 point = new Vector3();


            mousePos.x = currentEvent.mousePosition.x;
            mousePos.y = GetComponent<Camera>().pixelHeight - currentEvent.mousePosition.y;
            point = GetComponent<Camera>().ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 0.0f));

           
                GameObject autre = Instantiate(PrefTower, mouseWorldPos, Quaternion.identity) as GameObject;
                timeUntilSpawnTower = spawnTowerCooldown;
            }
        }
    }
}
