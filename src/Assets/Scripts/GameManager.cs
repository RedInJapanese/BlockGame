using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{

    public bool end = false;
    public GameObject complete;
    public PlayerMovement p;

    public void CompleteLevel() {
        Debug.Log("Complete Screen Activated.");
        complete.SetActive(true);
        p.enabled = false;

    }
    public void EndGame(){
        if(!end){
            Debug.Log("Game Over Screen");
            end = true;
            Invoke("Restart", 2f);
        }
    }
    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
