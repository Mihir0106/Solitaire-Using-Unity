using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCount : MonoBehaviour
{
    public Text MoveCountText;
    public int count;

    public static MoveCount instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        count = 0;
        MoveCountText.text = "Moves: ";
    }

    // Update is called once per frame
    void Update()
    {
        MoveCountText.text = "Moves: " + count;
    }

    public void Resets()
    {
        count = 0;
        SCoreManager.instance.score = 0;
    }
}
