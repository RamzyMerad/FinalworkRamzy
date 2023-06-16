using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyTest : MonoBehaviour
{

    // A test script to test to fly like flappy bird (but in 3D) using a rigidbody 

    public float speed = 1f;
    public float jumpForce = 1f;

    public bool isGrounded = true;
    
    private Rigidbody rb;

    //add the camera 
    public Camera Camera;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //find the camera by tag
        Camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // we will use force to move the player and speed to move the player forward or backward and also give the player the possibility to rotate the player (left and right)
    void Update()
    {

          //we need to check if the player is pressing the spacebar to jump
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //we need to add a force to the player to make it jump
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }

        //we need to check if the player is grounded or not (because you can move in the air and also walk on the ground)
        if (isGrounded)
        {
          

            //we will also change the position of the player to move it forward or backward using transform.position
            //use the axis to move the player forward or backward
            float moveVertical = Input.GetAxis("Vertical");
            transform.position += transform.forward * moveVertical * speed * Time.deltaTime;

            //we will rotate the player using the mouse (left and right)
            //float rotateHorizontal = Input.GetAxis("Mouse X");
            //we will rotate the player using the mouse (up and down) (we will reverse the axis because it's inverted)
            //we will also give some extra up rotation to the player to make it more realistic
            //float rotateVertical = Input.GetAxis("Mouse Y");
            //transform.Rotate(-rotateVertical, rotateHorizontal, 0f);

            //now we want to modify the script to make it work using a vr headset (we will use the oculus quest)

            //to start i need to change the input to work with the oculus quest controllers
            //about the movement we don't need to change anything because we are using axis and it work with the left joystick of the oculus quest controllers
            //about the rotation we need to use the camera rotation (the camera is the head of the player) 
            //we will use the camera rotation to rotate the player (we will use the camera rotation on the y axis to rotate the player left and right)
            //we will also use the camera rotation on the x axis to rotate the player up and down (we will also reverse the axis because it's inverted)
            transform.rotation = Quaternion.Euler(Camera.main.transform.rotation.eulerAngles.x, Camera.main.transform.rotation.eulerAngles.y, 0f);
            


        }

        //check if is grounded
        if (Physics.Raycast(transform.position, Vector3.down, 1f))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

    }

}
