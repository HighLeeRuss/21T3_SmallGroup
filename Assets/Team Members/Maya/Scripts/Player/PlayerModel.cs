using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    public GameObject abductorLight;
    private Rigidbody rb;
    [SerializeField] private SphereCollider soundBubble; 
    //public PlayerInput player1Controls;
    private PlayerTestControls buttonMap;
    //private Vector2 direction;
    public float speed;
    public int score;

    void Awake()
    {
        //check which player you are
        //set controls for player1/2
        //player1Controls = GetComponent<PlayerInput>();//add the parameter of player1/2
        abductorLight.GetComponent<Light>().spotAngle = 5f;
        abductorLight.GetComponent<Collider>().enabled = false;
        buttonMap = new PlayerTestControls();
        buttonMap.Player1Gameplay.Enable();
        buttonMap.Player1Gameplay.Move.performed += Move;
        buttonMap.Player1Gameplay.Abduct.performed += Abduct;
        buttonMap.Player1Gameplay.Abduct.canceled += Abduct;
        
        rb = GetComponent<Rigidbody>();
        GetComponent<HealthComponent>().onDeathEvent += Die;

        soundBubble = GetComponent<SphereCollider>();

    }

    public void Move(InputAction.CallbackContext context)
    {
        //rb.AddForce(transform.position * player1Controls.actions, ForceMode.Acceleration);
        Debug.Log(context);
        Vector2 inputVector = context.ReadValue<Vector2>();
        rb.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * speed, ForceMode.Force);
    }

    public void Abduct(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            abductorLight.GetComponent<Collider>().enabled = true;
            abductorLight.GetComponent<Light>().spotAngle = 30f;
            buttonMap.Player1Gameplay.Move.Disable();
        }

        if (context.canceled)
        {
            //Debug.Log("let go");
            abductorLight.GetComponent<Collider>().enabled = false;
            abductorLight.GetComponent<Light>().spotAngle = 5f;
            buttonMap.Player1Gameplay.Move.Enable();
        }
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


