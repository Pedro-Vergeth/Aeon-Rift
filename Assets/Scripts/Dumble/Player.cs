using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Player : MonoBehaviour
{
    public int health = 100;
    public float movementSpeed = 50.0f;
    public float runSpeed = 70.0f;
    public float stamina = 10.0f;


    private Vector3 inputs;
    private Animator playerAnimatorController;
    void Start()
    {
        playerAnimatorController = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ToMoviment();
        Run();
    }

    public void ToMoviment()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
            playerAnimatorController.SetBool("walkingFoward", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);
            playerAnimatorController.SetBool("walkingBack", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
            playerAnimatorController.SetBool("walkingLeft", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
            playerAnimatorController.SetBool("walkingRight", true);
        }
        else
        {
            playerAnimatorController.SetBool("walkingFoward", false);
            playerAnimatorController.SetBool("walkingLeft", false);
            playerAnimatorController.SetBool("walkingRight", false);
            playerAnimatorController.SetBool("walkingBack", false);
        }
    }
    
    public void Run()
    {
        if (stamina > 0 && Input.GetKey(KeyCode.LeftShift))
        {
            Debug.Log("Correndo" + stamina);
            stamina--;
        }
        else if (!Input.GetKey(KeyCode.LeftShift) && stamina <= 10)
        {
            stamina++;
            Debug.Log("Parado");
        }
    }
    
}
