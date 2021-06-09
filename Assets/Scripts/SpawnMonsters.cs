using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnMonsters : MonoBehaviour
{   
    public GameObject Monster;
    public int level=50;
    public  int gameover;


    private void Start()
    {
        gameover = 0;
    }
    void Update()
    {
        
        if (gameover<10) TimeSpawn(Random.Range(0, level));


    }


    void  TimeSpawn( int num)
    {
        if (num == 9)     
            СoordinateSpawn();        
    }

    void СoordinateSpawn()
    {
        Instantiate(Monster, new Vector2(Random.Range(-2.4f, 2.4f), Random.Range(-4.4f, 3f)), Quaternion.identity);
        gameover++;
    }
}
