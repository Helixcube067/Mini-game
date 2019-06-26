using UnityEngine;

public class HazardBehavior : MonoBehaviour {
    public PlayerMove movement;
    public Intertwerp stralker;
    private int timer = 100;
    private int ticker = 0;

    void FixedUpdate()
    {
        if (ticker < timer)
        {
            stralker.enabled = false;
            timer--;
        }

        else if (timer == 0)
        {
            stralker.enabled = true;
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Hazard")
        {
            movement.enabled = false;
            FindObjectOfType<SceneMovement>().EndGame();
        }

        else if (collisionInfo.collider.tag == "Powerup")
        {
            Debug.Log("i hit");
            timer = timer + 100;
            collisionInfo.gameObject.SetActive(false);
        }
    }
    void OnPowerup(Collision playerCol)
    {
        if (playerCol.collider.tag == "Powerup")
        {
            Debug.Log("i hit");
            timer = timer + 100;
            playerCol.gameObject.SetActive(false);
        }
    }

    public int GetTimer()
    {
        return timer;
    }
}
