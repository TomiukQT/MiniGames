using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame1 : MonoBehaviour {

    public Transform[] cables;
    public char[] inputs;
 
    void Start()
    {
        cables = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            cables[i] = transform.GetChild(i);

        }
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            cables[0].GetComponent<Animation>().Play("slide");
        }
        else if (Input.GetMouseButtonUp(0))
        {
            cables[0].GetComponent<Animation>().Play("slideDown");
        }


        

    }

    public char GetRandomChar()
    {
        char ch = 'a';




        return ch;
    }
}
