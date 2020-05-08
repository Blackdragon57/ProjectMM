using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch_Item : MonoBehaviour
{
    public static bool ItemASwitch = false;
    public static bool ItemBSwitch = false;
    public Button A;
    public Button B;
    public GameObject Itemwahl;
    public GameObject Game;

    public Sprite Schwert;

    private GamePlayManager GamePlayManager;

    void Start()
    {
        //A = GetComponent<Button>();
        //B = GetComponent<Button>();
    }

    private void Awake()
    {
        GamePlayManager = FindObjectOfType<GamePlayManager>();
    }
    public void SetButtonAActive()
    {
        if(ItemASwitch == true)
        {
            A.GetComponent<Image>().color = new Color(255, 255, 255);
            ItemASwitch = false;
        }
        else { 
            ItemASwitch = true;
            ItemBSwitch = false;
            A.GetComponent<Image>().color = new Color(255,0,0);
            B.GetComponent<Image>().color = new Color(255, 255, 255);
        }

        if (ItemBSwitch == true)
        {
            B.GetComponent<Image>().color = new Color(255, 255, 255);
            ItemBSwitch = false;
        }
        
    }
    public void SetButtonBActive()
    {
        if (ItemBSwitch == true)
        {
            B.GetComponent<Image>().color = new Color(255, 255, 255);
            ItemBSwitch = false;
        }
        else
        {
            ItemASwitch = false;
            ItemBSwitch = true;
            B.GetComponent<Image>().color = new Color(255, 0, 0);
            A.GetComponent<Image>().color = new Color(255, 255, 255);
        }

        if (ItemASwitch == true)
        {
            A.GetComponent<Image>().color = new Color(255, 255, 255);
            ItemASwitch = false;
        }
    }

    public void ChangeItemImage(string Item)
    {
        if(ItemASwitch == true) { 
            switch (Item)
            {
                case ("Schwert"):
                    A.image.overrideSprite = Schwert;
                    A.GetComponent<Image>().color = new Color(255, 255, 255);
                    A.GetComponentInChildren<Text>().text = "";
                    Itemwahl.SetActive(false);
                    Game.SetActive(true);
                    GamePlayManager.ItemA = "Schwert";
                    if (GamePlayManager.ItemB == "Schwert")
                    {
                        GamePlayManager.ItemB = null;
                        B.GetComponentInChildren<Text>().text = "ItemB";
                        B.image.overrideSprite = null;
                    }
                    Debug.Log("Item = " + Item);
                 break;
            }
        }

        if (ItemBSwitch == true)
        {
            switch (Item)
            {
                case ("Schwert"):
                    B.image.overrideSprite = Schwert;
                    B.GetComponent<Image>().color = new Color(255, 255, 255);
                    B.GetComponentInChildren<Text>().text = "";
                    Itemwahl.SetActive(false);
                    Game.SetActive(true);
                    GamePlayManager.ItemB = "Schwert";
                    if (GamePlayManager.ItemA == "Schwert")
                    {
                        GamePlayManager.ItemA = null;
                        A.GetComponentInChildren<Text>().text = "ItemA";
                        A.image.overrideSprite = null;
                    }
                    Debug.Log("Item = " + Item);
                    break;
            }
        }
    }

    public void ShowChooseItem()
    {
        Itemwahl.SetActive(true);
        Game.SetActive(false);
    }

    public void CloseChooseItem()
    {
        Itemwahl.SetActive(false);
        Game.SetActive(true);
    }
}
