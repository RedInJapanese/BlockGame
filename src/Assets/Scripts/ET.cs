using UnityEngine;

public class ET : MonoBehaviour
{
    public GameManager gm;

    public void OnTriggerEnter() {
        Debug.Log("Level Cleared.");
        gm.CompleteLevel();
    }
}
