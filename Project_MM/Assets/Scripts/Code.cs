using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Code : MonoBehaviour
{
    public int int_Code = 0;
    public int counter = 0;
    public Image Code1231;
    public GameObject Zahlenanzeige;
    
    public bool Code1231_done = false;

    public void Add_Digit(int digit)
    {
        switch (counter)
        {
            case 0:
                int_Code = digit * 1000;
                break;
            case 1:
                int_Code = int_Code + (digit * 100);
                break;
            case 2:
                int_Code = int_Code + (digit * 10);
                break;
            case 3:
                int_Code = int_Code + digit;
                break;
        }
        counter++;
        Zahlenanzeige = GameObject.Find("Zahlenanzeige");
        Zahlenanzeige.GetComponent<Text>().text = "" + int_Code;
        if (counter == 4)
        {
            CheckCode();
        }   
    }

    public void CheckCode()
    {
        switch (int_Code)
        {
            case 1231:
                SceneManager.LoadScene("Code1231");
                Code1231_done = true;
                Debug.Log("Das war richtig");
                break;
            default:
                Debug.Log("Leider nicht richtig");
                Clear();
                break;
        }
    }

    public void Clear()
    {
        counter = 0;
        int_Code = 0;
        Zahlenanzeige = GameObject.Find("Zahlenanzeige");
        Zahlenanzeige.GetComponent<Text>().text = "" + int_Code;
    }
}
