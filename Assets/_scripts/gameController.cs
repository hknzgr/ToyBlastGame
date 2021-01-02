using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour {

    public static int boardSizeX = 6;
    public static int boardSizeY = 8;
    public static GameObject[,] backs;
    public GameObject stoneObj;
    public GameObject backObj;
    Vector3 startPos = new Vector3(-2.5f, 3.5f, 0);
	void Start ()
    {
        backs = new GameObject[boardSizeX, boardSizeY];
        CreateBoard();
        CreateStones(8);
	}
	
	
	void Update ()
    {
		
	}

    void CreateBoard()
    {
        Vector3 startPos = new Vector3(-2.5f, 3.5f, 0);
        for (int i = 0; i < boardSizeY; i++)
        {
            
            for (int j = 0; j < boardSizeX; j++)
            {
                GameObject backClone = Instantiate(backObj, startPos, Quaternion.identity);
                backClone.name = "back" + i + j;
                backClone.GetComponent<backScript>().i = i;
                backClone.GetComponent<backScript>().j = j;
                backs[j, i] = backClone;
                startPos.x++;
            }
            startPos.y--;
            startPos.x = -2.5f;
        }
    }

    void CreateStones(int amount)
    {
        Vector3 startPos = new Vector3(-2.5f, 6, 0);
        for (int i = 0; i < amount; i++)
        {
            for (int j = 0; j < boardSizeX; j++)
            {
                GameObject stonClone = Instantiate(stoneObj, startPos, Quaternion.identity);
                startPos.x++;
            }
            startPos.y++;
            startPos.x = -2.5f;
        }
    }
}
