using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TurningAround : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float Speed;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 10f;
    [SerializeField] float bootsSpeed = 30f;
    float moveAmount;

    private void Start()
    {
        Speed = moveSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        moveAmount = Input.GetAxis("Vertical") * Speed * Time.deltaTime; 
        transform.Rotate(0,0, - steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Boots") 
        {
            Speed = bootsSpeed;
            Debug.Log("Boots");
            
        }
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
            Speed = slowSpeed;
    }
}
