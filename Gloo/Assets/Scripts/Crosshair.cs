using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour {
    public Transform crosshair;
    public Sprite idle;
    public Sprite shoot;

	// Use this for initialization
	void Start () {
        Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
        crosshair.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) - new Vector3 (0,0,-10);
       if (Input.GetMouseButtonDown(0))
        {
            GetComponent<SpriteRenderer>().sprite = shoot;
            Invoke("BackToIdle", 0.2f);
        }
        
	}

    void BackToIdle()
    {
        GetComponent<SpriteRenderer>().sprite = idle;
    }
    
}
