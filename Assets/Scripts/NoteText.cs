using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteText : MonoBehaviour {

    [SerializeField]
    Canvas messageCanvas;

    private bool inTrigger = false;

    public GameObject player;
    private PlayerScript playerscript;

    private string curNote;

    // Use this for initialization
    void Start () {

        playerscript = player.GetComponent<PlayerScript>();
        curNote = playerscript.HeldItem.ToString();
        messageCanvas.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        //if (inTrigger)
        //{
        //if (Input.GetKeyDown(KeyCode.Return))
        /*  if (Input.GetKeyDown(KeyCode.Return) && (inTrigger))
          {
              //Need to check if player already "holds" a note
              //and ask if they want to swap if they do
              //and then don't destroy object
              //if (curNote.ToString() != "")
              if (string.Compare(curNote, "") == 1)
              {
                  //find curNote and make active
                  GameObject replaceNote = GameObject.Find(curNote.ToString());
                  replaceNote.SetActive(true);
              }

              //Destroy(gameObject);
              gameObject.SetActive(false); 

          }*/

        //}
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.name == "Player")
        {
            inTrigger = true;
            ShowMessage();
            Update();
        }
    }

    private void ShowMessage()
    {
        messageCanvas.enabled = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        inTrigger = false;
        //if (other.name == "Player")
        //{
            HideMessage();
        //}
    }

    private void HideMessage()
    {
        messageCanvas.enabled = false;
    }
}
