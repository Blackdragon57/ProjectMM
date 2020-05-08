using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Switch_Scene : MonoBehaviour
{
    private GamePlayManager GamePlayManager;

    void Awake()
    {
        GamePlayManager = FindObjectOfType<GamePlayManager>();
    } 

    public void Lade_Szene(string Szene)
    {
        SceneManager.LoadScene(Szene);
    }

    public void Lade_aktuelle_Szene()
    {
        string akteuelleSzene = ""+GamePlayManager.Position;
        SceneManager.LoadScene(akteuelleSzene);
    }

    public void Lade_Tile(int NewPosition)
    {
        Debug.Log("Position ist " + GamePlayManager.Position);
        Debug.Log("New Position ist " + NewPosition);
        int NewTile = GamePlayManager.Position + NewPosition;
        GamePlayManager.updatePosition(NewTile);
        string NextTile = "" + NewTile;
        SceneManager.LoadScene(NextTile);
        Debug.Log("Position ist " + GamePlayManager.Position);
        Debug.Log("New Position ist " + NewPosition);
    }
}
