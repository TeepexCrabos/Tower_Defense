using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public int gold;
    public bool gameOver;

    

    

    // Start is called before the first frame update
    void Start()
    {
        gold = 0;
        StartGame();
    }

    public void StartGame() 
    {
        gold = 200;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        gameOver = true;
        Application.Quit();
    }

    public void goldplus()
    {
        gold += 100;
    }

    GameObject PrefTower;

    
}
