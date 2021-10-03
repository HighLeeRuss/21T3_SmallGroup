using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    private Rigidbody rb;
    //public PlayerInput player1Controls;
    private PlayerTestControls buttonMap;
    //private Vector2 direction;

    public float speed;
    
    
    void Awake()
    {
        //check which player you are
        //set controls for player1/2
        //player1Controls = GetComponent<PlayerInput>();//add the parameter of player1/2
        buttonMap = new PlayerTestControls();
        buttonMap.Player1Gameplay.Enable();
        buttonMap.Player1Gameplay.Move.performed += Move;
        
        rb = GetComponent<Rigidbody>();
        GetComponent<HealthComponent>().onDeathEvent += Die;
    }

    public void Move(InputAction.CallbackContext context)
    {
        //rb.AddForce(transform.position * player1Controls.actions, ForceMode.Acceleration);
        Debug.Log(context);
        Vector2 inputVector = context.ReadValue<Vector2>();
        rb.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * speed, ForceMode.Force);
    }

    public void Die()
    {
        EditorApplication.ExitPlaymode();
        //GetComponent<HealthComponent>().DeathFunction();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 direction = buttonMap.Player1Gameplay.Move.ReadValue<Vector2>();
        rb.AddForce(new Vector3(direction.x, 0, direction.y) * speed, ForceMode.Force);
    }
}

