using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{
    private int score = 0;
    [SerializeField] private Text TextScore;
    // Start is called before the first frame update
    void Start()
    {
        
        TextScore.text = "Ñ÷¸ò: " + score.ToString();
    }
    public void IncrimentScore()
    {
        score++;
        Update();
    }

    // Update is called once per frame
    void Update()
    {
        TextScore.text = "Ñ÷¸ò: " + score.ToString();
    }
}
