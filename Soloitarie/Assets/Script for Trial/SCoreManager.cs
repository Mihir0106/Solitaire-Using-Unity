using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCoreManager : MonoBehaviour
{
    public static SCoreManager instance;
    public Text ScoreText;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        ScoreText.text = "Score: ";
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (score >= 0)
        {
            ScoreText.text = "Score: " + score;
        }
        else
        {
            ScoreText.text = "Score: 0";
            score = 0;
        }

        if(GameManager.Instance.closedDrawPile.Cards.Count == 0)
        {
            score -= 20;
        }
    }

}
