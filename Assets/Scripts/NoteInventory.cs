using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteInventory : MonoBehaviour
{

    public string curNote;
    private string newNote;
    private bool inTrigger = false;


    void Start()
    {
        curNote = "";
        newNote = "";
        //print(curNote.ToString());
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && (inTrigger))
        {

            if (string.Compare(curNote, "") == 1)
            {
                //find curNote icon and make active
                GameObject oldNoteIcon = GameObject.Find("Notes").transform.Find(curNote.ToString()).gameObject;
                oldNoteIcon.SetActive(true);
            }

            GameObject newNoteIcon = GameObject.Find(newNote.ToString());
            newNoteIcon.SetActive(false);
        
            //print("key pressed");
            curNote = newNote;
            //print(curNote.ToString());
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Note")
        {
            //print("this is a note");
            inTrigger = true;
            newNote = other.name;
            //print(newNote);
            Update();
        }
    }


    void OnTriggerExit2D(Collider2D other)
    {
        inTrigger = false;
    }

}
