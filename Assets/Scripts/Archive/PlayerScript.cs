using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public string HeldItem;

    private string NewItem;

    private bool inTrigger = false;
    
	// Use this for initialization
	void Start () {

        HeldItem = "";
        NewItem = "";

        //print(HeldItem.ToString());

    }
	
	// Update is called once per frame
	void Update () {

        //if (inTrigger)
        //{
        //if (Input.GetKeyDown(KeyCode.Return))
        if (Input.GetKeyDown(KeyCode.Return) && (inTrigger))
        {
                //print("key pressed");
                HeldItem = NewItem;
                //print(HeldItem.ToString());
            }
        //}
    }

    void OnTriggerEnter2D(Collider2D other)
    { 

        if (other.tag == "Note")
        {

            //print("this is a note");
            inTrigger = true;
            NewItem = other.name;
            //print(NewItem);
            Update();

            /*if (Input.GetKeyDown(KeyCode.Return))
            {
                print("key pressed");
                HeldItem = other.name;
            }*/
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        inTrigger = false;
    }

}
