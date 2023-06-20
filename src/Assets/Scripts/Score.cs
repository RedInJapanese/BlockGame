using System;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public PlayerMovement p;
    public bool out_of_bounds;
    public double score;
    // Update is called once per frame
    void Update()
    {
            score = player.position.z + 4821.0;
            scoreText.text = (player.position.z+4821.0).ToString("0");
            Console.WriteLine("lskdjflksjdf");
    }
}
