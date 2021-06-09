using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int Hp=1;
    public float speed;

    void OnMouseUp()
    {
        Destroy(gameObject);
        Score.score++;
        GameObject.FindGameObjectWithTag("GameController").GetComponent<SpawnMonsters>().gameover--;

    }
}
