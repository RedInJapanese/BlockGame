using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement p;
    void OnCollisionEnter(Collision c) {
        if(c.collider.tag == "Obstacle") {
            Debug.Log("Hit Obstacle.");
            FindObjectOfType<GameManager>().EndGame();
            p.enabled = false;
        }
    }
}
