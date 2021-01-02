using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoneScript : MonoBehaviour {

    public string color = "";
    public Sprite blue;
    public Sprite yellow;
    public GameObject backObj;
	void Start ()
    {
        int r = Random.Range(1, 3);
        switch (r)
        {
            case 1:
                color = "blue";
                this.GetComponent<SpriteRenderer>().sprite = blue;
                break;
            case 2:
                color = "yellow";
                this.GetComponent<SpriteRenderer>().sprite = yellow;
                break;
        }
        
	}
	
	
	void Update ()
    {
		
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        backObj = col.gameObject;
        col.gameObject.GetComponent<backScript>().stoneObj = this.gameObject;
    }

    private void OnMouseDown()
    {
        backScript.Initialize();
        backObj.GetComponent<backScript>().Control();
        //backObj.GetComponent<backScript>().yokEt();
    }

}
