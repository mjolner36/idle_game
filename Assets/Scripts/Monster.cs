using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int Hp=1;
    public float speed;
    AudioSource click;
    private void Update()
    {
        if (SpawnMonsters.pause == true)
        {
            Destroy(gameObject);
        }
    }

    void OnMouseUp()
    {
        if (SpawnMonsters.pause == false) 
        { 
            Score.score++;
            GameObject.FindGameObjectWithTag("GameController").GetComponent<SpawnMonsters>().gameover--;
            click = click = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>();
            click.Play();
            Destroy(gameObject);
        }

    }

    
}
