using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorBehavior : MonoBehaviour {
    public Rigidbody reward1;
    public Rigidbody reward2;
    public Rigidbody bad;
    bool tradeOff = false;

    public void BulletHell(Rigidbody reward1, Rigidbody reward2, Rigidbody bad) {
        tradeOff = true;
        for (int i = 0; i < 11; i++) {
            int why = Random.Range(10, 10);
            int ex = Random.Range(-15, 30);
            int zed = Random.Range(-10, 25);
            Instantiate(bad, new Vector3(ex, why, zed), Quaternion.identity);
            Instantiate(reward1, new Vector3(ex, why, zed), Quaternion.identity);
            Instantiate(reward2, new Vector3(ex, why, zed), Quaternion.identity);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Collectible" || col.gameObject.tag == "Star")
        {
            col.gameObject.SetActive(false);
            if(col.gameObject.activeInHierarchy == tradeOff)
            {
                Invoke("BulletHell", 1.5f);
            }
        }
    }
}
