using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;

public class Fight : MonoBehaviour
{

    // you must drag and drop images into all the blanks in the inspector!!!

    public Texture2D pic0;
    public Texture2D pic1;
    public Texture2D pic2;

    public int pick;

    Texture2D[] pics;
    int i;
    float timer;


    void Start()
    {

        //pack images into an array to make things easy
        pics = new Texture2D[3];

        pics[0] = pic0;
        pics[1] = pic1;
        pics[2] = pic2;

    }

    void Update()
    {


        timer -= Time.deltaTime;
        if (timer < 0)
        {
            timer = 2.5f;//<--this happens about every second;

            //get a random number not equal to current
            i = pick;
            while (i == pick)
            {
                pick = Random.Range(0, 3);
            }
        }
    }

    void OnGUI()
    {
        //display our image
        GUI.DrawTexture(new Rect(50, 50, 300, 300), pics[pick]);
    }
}