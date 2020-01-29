using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMover : MonoBehaviour
{
    public Transform tf;

    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        tf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        //if player presses up.
        if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                //Move up constantly
                tf.position += transform.up;
            }
            //moves the sprite down when held
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                //Move down constantly
                tf.position -= transform.up;
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                //Move left constantly
                tf.position -= transform.right;
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                //Move right constantly
                tf.position += transform.right;
            }
        }
        else
        {
            //only works if shift is not held down
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Move up constantly
            tf.position = tf.position + Vector3.up * Time.deltaTime;
        }
       //moves the sprite down when held
        if  (Input.GetKey(KeyCode.DownArrow))
        {
            //Move down constantly
            tf.position = tf.position + Vector3.down * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Move left constantly
            tf.position = tf.position + Vector3.left * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Move right constantly
            tf.position = tf.position + Vector3.right * Time.deltaTime;
        }
        //reset
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tf.position = new Vector3(0, 0, 0);
        }
    }
   

}
