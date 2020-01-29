using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disabler : MonoBehaviour
{
    public SpriteMover SpriteMover;
    // Start is called before the first frame update
    void Start()
    {
        SpriteMover = gameObject.GetComponent<SpriteMover>();
    }

    // Update is called once per frame
    void Update()
    {
        //when p is pressed down it disables sprite mover until p is pressed again
        if (Input.GetKeyDown(KeyCode.P))
        {
            //sets sprite mover script disabled
            SpriteMover.enabled = (!SpriteMover.enabled);
        }
    }
}
