using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class HintSystem : MonoBehaviour
{
    public static HintSystem instance;
    public GameObject[] possible = new GameObject[8];
    private Card[] pCards = new Card[8];
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 7; i++)
        {
            if (possible[i].GetComponent<MainPile>().Cards.Last<Card>() != null)
            {
                //   Card c1 = possible[i].GetComponent<MainPile>().Cards[i];
                pCards[i] = possible[i].GetComponent<MainPile>().Cards.Last<Card>();    //bottoms ke last card ko pick kiyya 
                // print(pCards[i]);
            }
            else
            {
                Debug.Log("empty pile");
            }
        }
    }

    public void Hint()
    {

        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if(pCards[i].value == 1) // agr bottoms ke last card ace ha to usse top m put karne ke iyya hint karre 
                {
                    Debug.Log(pCards[i] + "put on Top");
                    break;
                }

                else if (pCards[i].CardCanBePutOnHere(pCards[j]))    //compare kiyya ek card ko bakki sab se ke vo unke upper place able hn ke nahi  
                {
                    Debug.Log(pCards[j] + "can be put on " + pCards[i]);
                    break;
                    // pCards[i].GetComponent<SpriteRenderer>().color = Color.blue;
                    // pCards[j].GetComponent<SpriteRenderer>().color = Color.green;
                }
            }
        }
        Debug.Log("Click on deck");
    }
}


