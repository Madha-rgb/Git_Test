using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] int movementSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D)) //"if" does not need { } if there is only one line of code for it. I have removed them now.
        {
            rb.AddForce(Vector2.right * movementSpeed);
        }
        //when adding "new Vector", the "new" specifies that this is a child of Vector 2 as a whole. It's the same as creating
        //an object in Unity, but in code and for Vector.
        //ATTENTION: this is the example I was talking about. "rb.AddForce(new Vector2 = (3.0));"
    }

}
