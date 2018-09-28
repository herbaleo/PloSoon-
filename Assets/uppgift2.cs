using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uppgift2 : MonoBehaviour {

    public bool ifbool;
    public int value;

	// Use this for initialization
	void Start () {
		
        if(ifbool == true)
        {
            print("ja");

        }
        else
        {
            print("nej");
        }

        // != inte lika med
        // == lika med
        // > större än
        //< mindre än
        // >= större eller lika med
        // < mindre eller lika med
        // && och
        // || eller

        if (value >= 5)
        {
            print("adam är bra");
        }
        else if(value == 4)
        {
            print("adam är dålig´");
        }
        else if( value == 3)
        {
            print("adam är sämst");
        }
        else if(value == 2)
        {
            print("adam är en hefre");
        }
        else if(value == 1)
        {
            print("adam är en körv");
        }
	}
	
	// Update is called once per frame
	void Update () {
      
        if(Input.GetKeyDown(KeyCode.E))
        {
           print("du EEEEEEE");
        }


        /* if (ifbool == true)
        {
            print("ja");

        }
        else
        {
            print("nej");
        }

        if (value == 5)
        {
            print("adam är bra");
        }
        else if (value == 4)
        {
            print("adam är dålig´");
        }
        else if (value == 3)
        {
            print("adam är sämst");
        }
        else if (value == 2)
        {
            print("adam är en hefre");
        }
        else if (value == 1)
        {
            print("adam är en körv");*/
        }
    }

