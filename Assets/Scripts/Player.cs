using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D myRigidBody;
    private Animator anim;
    [SerializeField]
    private float MovementSpeed;

    // Use this for initialization
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");
        HandleMovement(horizontal, vertical);

        GetComponent<Animator>().SetFloat("vertMoves", vertical);
        GetComponent<Animator>().SetFloat("horMoves", horizontal);
    }
    private void HandleMovement(float horizontal, float vertical)
    {
        myRigidBody.velocity = new Vector2(horizontal * MovementSpeed, myRigidBody.velocity.y);
        myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, vertical * MovementSpeed);

        if (vertical == 0 && horizontal == 0)
        {
            GetComponent<Animator>().SetBool("Idle", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Idle", false);
        }

        if (vertical > 0 && horizontal < 0)
        {
            GetComponent<Animator>().SetBool("+ve_left_x_diagonal", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("+ve_left_x_diagonal", false);
        }
        if (vertical > 0 && horizontal > 0)
        {
            GetComponent<Animator>().SetBool("+ve_right_x_diagonal", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("+ve_right_x_diagonal", false);
        }

        if (vertical < 0 && horizontal < 0)
        {
            GetComponent<Animator>().SetBool("-ve_left_x_diagonal", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("-ve_left_x_diagonal", false);
        }    
        if (vertical < 0 && horizontal > 0)
        {
            GetComponent<Animator>().SetBool("-ve_right_x_diagonal", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("-ve_right_x_diagonal", false);
        }
    }
    
}