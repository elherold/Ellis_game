using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonScript : MonoBehaviour
{
    // First thing we need is a reference to our character controller
    //[SerializeField]
    //private CharacterController _controller;

    [SerializeField]
    private float _speed = 600f;
    [SerializeField]
    private float _jumpingSpeed = 50f;

    // -- time delay --
    private float _coolDownTime = 2f;
    private float _nextJumpTime = 0f;

    [SerializeField]
    private Rigidbody RB;

    //Making truns smoother 
    [SerializeField]
    private float turnSmoothTime = 0.1f;

    [SerializeField]
    private Camera cam;

    Vector3 direction = new Vector3(-257.9f, 43.7f, -13.2f);

    // Start is called before the first frame update
    void Start()
    {
        
        //START POSITION
        transform.position = direction;

    }

    void Update()
    {
        //Get and store horizontal and vertical movement directions
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(horizontal, 0f, vertical);

        //updated direction vector
        Vector3 movementRotated = Quaternion.AngleAxis(cam.transform.eulerAngles.y, Vector3.up) * movement;

        //adjust rotation of player
        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movementRotated.normalized), 0.2f);
            transform.Translate(movement * _speed * Time.deltaTime, Space.World);
        }


    // Update is called once per frame
    //void Update()
    //{
        // Get and store horizontal and vertical movement directions
        //float horizontal = Input.GetAxisRaw("Horizontal");
        //float vertical = Input.GetAxisRaw("Vertical");
        //Vector3 movement = new Vector3(horizontal, 0f, vertical).normalized;

        

        //adjust rotation of player
        //if (movement != Vector3.zero)
        //{
           // float targetAngle = Mathf.Atan2(transform.position.x, transform.position.z)*Mathf.Rad2Deg;
           // transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

           // transform.Translate(movement * _speed * Time.deltaTime, Space.World);
        //}

        

        // JUMPING 
        //if (Input.GetKeyDown("space") && _nextJumpTime < Time.time)
        //{
            //Debug.Log("space");
            //RB.velocity += new Vector3(0f, _jumpingSpeed, 0f);
            //Debug.Log(RB.velocity);
            //_nextJumpTime = Time.time + _coolDownTime;
        //}

    }
}
