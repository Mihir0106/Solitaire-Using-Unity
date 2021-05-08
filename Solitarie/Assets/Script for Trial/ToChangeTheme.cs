using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToChangeTheme : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region ForBackGround
    //array for backGround sprites 
    public Sprite[] spriteForBackground = new Sprite[4];
    public InputField ForLockedBackGround;
    public GameObject LOckedSprite;
    //Method
    public void SetThisBackGround(int i)
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = spriteForBackground[i];
    }
    #endregion
    public void LockedCallForBackGround()
    {
        string str1 = ForLockedBackGround.text;
        if(str1 == "123456")
        {
            LOckedSprite.SetActive(false);
           
        }
    }

    #region ForCardBack
    //array for CardBack sprites
    public Sprite[] SpriteForCardBack = new Sprite[3];
    public InputField ForLockedCardback;
    public GameObject LockedSpriteForCardBack;

    //Method
    public void SetThisCardBack(int i)
    {
        GameManager.Instance.cardBack = SpriteForCardBack[i];
    }
    public void LockedCallForCardBack()
    {
        string str1 = ForLockedCardback.text;
        if (str1 == "123456")
        {
            LockedSpriteForCardBack.SetActive(false);

        }
    }
    #endregion


}





