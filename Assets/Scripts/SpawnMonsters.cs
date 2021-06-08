using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnMonsters : MonoBehaviour
{   
    public GameObject Monster;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Monster, new Vector2(Random.Range(-2.4f, 2.4f),Random.Range(-4.4f, 3f)), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
