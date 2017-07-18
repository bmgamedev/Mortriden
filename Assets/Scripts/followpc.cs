using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followpc : MonoBehaviour {

    //public float dampTime = 0.25f;
    //private Vector3 velocity = Vector3.zero;
    //public Transform target;

    static followpc instance = null;
    public GameObject player;       //Public variable to store a reference to the player game object
    private Vector3 offset;         //Private variable to store the offset distance between the player and camera

    void Awake()
    {
        /*if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }*/
    }

    

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = player.transform.position + offset;
    }
}
