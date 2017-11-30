using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject playerObj;
    public bool experiment2;

	// Use this for initialization
	void Start () {

        // Start experiment2 if asked
        // experiment2 will add the given gameObject after 10seconds and add it again every 10seconds
        // it simulate the presence of multiple players on a same game scene

        if (experiment2)
            InvokeRepeating("AddAPlayer", 10.0f, 10.0f);

    }
	
	// Update is called once per frame
	void Update () {
        
    }

    //Add a player add the given gameObject to the gameScene

    void AddAPlayer()
    {
        GameObject player = Instantiate(playerObj);
    }
}
