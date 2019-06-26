using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    int score;
    public Text scoreText;
    public FloorBehavior floor;
    public Rigidbody reward1;
    public Rigidbody reward2;
    public Rigidbody bad;

    void Start()
    {
        score = 0;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Collectible")
        {
            score = score + 1;
            floor.BulletHell(reward1, reward2, bad);
        }
        else if (col.gameObject.tag == "Star") {
            score = score + 2;
            floor.BulletHell(reward1, reward2, bad);
        }
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }
}
