using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Larry
public class GameManager : MonoBehaviour
{
    //variables in unity that are called

    //beachball
    public GameObject beachball;
    // Update is called once per frame
    void Update()
    {
        //should user press Q gameobject is disabled until pressed again
        if (Input.GetKeyDown(KeyCode.Q))
        {

            beachball.SetActive(!beachball.activeInHierarchy);
        }
        //if escape is pressed it will close the application

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
