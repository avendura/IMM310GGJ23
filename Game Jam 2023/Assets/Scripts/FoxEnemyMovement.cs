using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxEnemyMovement : MonoBehaviour
{
    private int number; //Directly stores the number. number is a variable and int is the type which is necessary.
    //private Rigidbody2D _rigidbody2D; //references another instance of a class of this type
    private Rigidbody _rigidbody;
    
    public float jumpForce = 10;
    public float movementSpeed = 4;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
       // _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() //All functions end with (). the first letters are all capitalized in a function.
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector3(horizontal, vertical);
        movement = movement * movementSpeed;
        //_rigidbody2D.AddForce(movement);
        _rigidbody.AddForce(movement);
            
        if (Input.GetKeyDown(KeyCode.Space)) //Input.Getkeydown takes a keycode when a button is pressed as true.
            // When not pressed, false.
        {
           // _rigidbody2D.AddForce(Vector2.up*jumpForce);
            _rigidbody.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
            
        }
        
    }

}
