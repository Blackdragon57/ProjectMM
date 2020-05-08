using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayManager : MonoBehaviour
{
    public static int Position = 0100;
    public bool item1Found = true;
    public bool item2Found = false;
    public bool item3Found = false;
    public bool item4Found = true;
    public bool item5Found = false;
    public bool item6Found = false;
    public bool item7Found = true;
    public bool item8Found = false;
    public bool item9Found = false;
    public bool item10Found = true;
    public bool item11Found = false;
    public bool item12Found = false;

    public GameObject Item1;
    public GameObject Item2;
    public GameObject Item3;
    public GameObject Item4;
    public GameObject Item5;
    public GameObject Item6;
    public GameObject Item7;
    public GameObject Item8;
    public GameObject Item9;
    public GameObject Item10;
    public GameObject Item11;
    public GameObject Item12;

    //public static Image ItemA;
    //public static Image ItemB;

    public static string ItemA = null;
    public static string ItemB = null;

    private void Awake()
    {
        if (item1Found == true)
        {
            Item1.SetActive(true); 
        }
        else
        {
            Item1.SetActive(false);
        }

        if (item2Found == true)
        {
            Item2.SetActive(true);
        }
        else
        {
            Item2.SetActive(false);
        }

        if (item3Found == true)
        {
            Item3.SetActive(true);
        }
        else
        {
            Item3.SetActive(false);
        }

        if (item4Found == true)
        {
            Item4.SetActive(true);
        }
        else
        {
            Item4.SetActive(false);
        }

        if (item5Found == true)
        {
            Item5.SetActive(true);
        }
        else
        {
            Item5.SetActive(false);
        }

        if (item6Found == true)
        {
            Item6.SetActive(true);
        }
        else
        {
            Item6.SetActive(false);
        }

        if (item7Found == true)
        {
            Item7.SetActive(true);
        }
        else
        {
            Item7.SetActive(false);
        }

        if (item8Found == true)
        {
            Item8.SetActive(true);
        }
        else
        {
            Item8.SetActive(false);
        }

        if (item9Found == true)
        {
            Item9.SetActive(true);
        }
        else
        {
            Item9.SetActive(false);
        }

        if (item10Found == true)
        {
            Item10.SetActive(true);
        }
        else
        {
            Item10.SetActive(false);
        }

        if (item11Found == true)
        {
            Item11.SetActive(true);
        }
        else
        {
            Item11.SetActive(false);
        }

        if (item12Found == true)
        {
            Item12.SetActive(true);
        }
        else
        {
            Item12.SetActive(false);
        }
    }

    public void updatePosition(int newPosition)
    {
        Position = newPosition;
    }

}
