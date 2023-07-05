using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Move our object based on input from other player
        // We'll need an IF STATEMENT when we want to get the player input


        // EXAMPLE...
        int playerScore = 1;
        playerScore++;
        playerScore = playerScore + 1;
        playerScore += 1;
        // END EXAMPLE

        // transform.position++; DOESN't WORK
        Vector3 moveDirection = Vector3.forward;

        // When player presses arrow keys (or WASD)
        //...the gameobject moves in respective direction

        // we need to CREATE A VECTOR
        // X, Y, Z
        // 0

        // if "pressing D", then move +X
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back;
        }

        // no jump...   so no +Y or -Y
        // if "pressing W", then move +Z
        // if "pressing S", then move -Z


        // the below is an example of one line code of the above 
        //transform.position += new Vector3(Input.GetAxis("Horizontal")), 0, Input.GetAxis("Vertical"); 

    }
}
