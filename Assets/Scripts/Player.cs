using UnityEngine; 

public class Player : MonoBehaviour
{
    public int health = 100;
    public float movementSpeed = 50.0f;
    public float runSpeed = 70.0f;
    public float stamina = 10.0f;
    
    void Start()
    {
        
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
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);   
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
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
