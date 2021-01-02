using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backScript : MonoBehaviour {

    public GameObject stoneObj;
    public int i;
    public int j;
	void Start ()
    {
		
	}
	
	
	void Update ()
    {
		
	}

    public bool isControlled = false;

    public static void Initialize()
    {
        for (int i = 0; i < gameController.boardSizeX ; i++)
        {
            for (int j = 0; j < gameController.boardSizeY; j++)
            {
                gameController.backs[i,j].GetComponent<backScript>().isControlled = false;
            }
        }
    }

    public void Control()
    {
        //down
        if (i + 1 < gameController.boardSizeY
            && gameController.backs[j, i+1].GetComponent<backScript>().isControlled == false 
            && gameController.backs[j, i+1].GetComponent<backScript>().stoneObj!=null)
        {
            string downColor = gameController.backs[j, i+1].GetComponent<backScript>().stoneObj.GetComponent<stoneScript>().color;
            if (downColor==stoneObj.GetComponent<stoneScript>().color)
            {
                isControlled = true;
                gameController.backs[j, i+1].GetComponent<backScript>().Control();
            }
        }

        //up
        if (i - 1 >= 0 && gameController.backs[j , i-1].GetComponent<backScript>().isControlled == false
            && gameController.backs[j, i-1].GetComponent<backScript>().stoneObj != null)
        {
            string upColor = gameController.backs[j, i-1].GetComponent<backScript>().stoneObj.GetComponent<stoneScript>().color;
            if (upColor == stoneObj.GetComponent<stoneScript>().color)
            {
                isControlled = true;
                gameController.backs[j , i-1].GetComponent<backScript>().Control();
            }
        }

        //right
        if (j + 1 < gameController.boardSizeX && gameController.backs[j+1 , i].GetComponent<backScript>().isControlled == false
            && gameController.backs[j+1, i].GetComponent<backScript>().stoneObj != null)
        {
            string rightColor = gameController.backs[j+1, i].GetComponent<backScript>().stoneObj.GetComponent<stoneScript>().color;
            if (rightColor == stoneObj.GetComponent<stoneScript>().color)
            {
                isControlled = true;
                gameController.backs[j+1, i].GetComponent<backScript>().Control();
            }
        }

        //left
        if (j -1 >=0 && gameController.backs[j -1, i].GetComponent<backScript>().isControlled == false
            && gameController.backs[j-1, i].GetComponent<backScript>().stoneObj != null)
        {
            string leftColor = gameController.backs[j-1, i].GetComponent<backScript>().stoneObj.GetComponent<stoneScript>().color;
            if (leftColor == stoneObj.GetComponent<stoneScript>().color)
            {
                isControlled = true;
                gameController.backs[j -1, i].GetComponent<backScript>().Control();
            }
        }

        //Destroy(this.stoneObj.gameObject);
        this.stoneObj.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        this.stoneObj = null;


    }

    public void yokEt()
    {
        string downColor = gameController.backs[j, i + 1].GetComponent<backScript>().stoneObj.GetComponent<stoneScript>().color;
        string upColor= gameController.backs[j, i - 1].GetComponent<backScript>().stoneObj.GetComponent<stoneScript>().color;
        string rightColor= gameController.backs[j+1, i].GetComponent<backScript>().stoneObj.GetComponent<stoneScript>().color;
        string leftColor= gameController.backs[j-1, i].GetComponent<backScript>().stoneObj.GetComponent<stoneScript>().color;
        Debug.Log("Down : " + downColor + "Up : " + upColor + "Right : " + rightColor + "Left : " + leftColor);
    }
}
