using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed { get; set; } = 3f;
    float CurrentMoveSpeed { get; set; } = 3f;
    public float RotationSpeed { get; set; } = 60f;
    //bool IsRunning;
    public CharacterController Controller;
    public GameObject Player;
    public bool IsGrounded = false;
    public float GroundDistance = 0.4f;
    public LayerMask GroundMask;
    public Transform GroundCheck;
    public Vector3 Velocity;
    float Gravity { get; set; } = -9.81f;
    public Camera Camera;
    // Start is called before the first frame update
    void Start()
    {
        Player = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        IsGrounded = Physics.CheckSphere(GroundCheck.position, GroundDistance, GroundMask);

        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Camera.transform.rotation = Quaternion.Lerp(Camera.transform.rotation, Time.time * CurrentMoveSpeed) ;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {

        }
        if (IsGrounded && Velocity.y < 0)
        {
            Velocity.y = -2f;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            //IsRunning = true;
            CurrentMoveSpeed = CurrentMoveSpeed * 2;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            //IsRunning = false;
            CurrentMoveSpeed = MoveSpeed;
        }
        if (x < 0)
        {
            Player.transform.Rotate(0, (-RotationSpeed *Time.deltaTime), 0);
        }

        if (x > 0)
        {
            Player.transform.Rotate(0, (RotationSpeed *Time.deltaTime), 0);
        }

        Vector3 move = transform.forward * z;
        
        Controller.Move(move * CurrentMoveSpeed * Time.deltaTime);
        Velocity.y += Gravity * Time.deltaTime;
        Controller.Move(Velocity * Time.deltaTime);
    }
}
