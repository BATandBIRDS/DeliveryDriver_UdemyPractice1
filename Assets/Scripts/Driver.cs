using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Variables
    [SerializeField]  float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float normalSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;


    
    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }
        else if(other.tag == "Bump")
        {
            moveSpeed = slowSpeed;
        }
        else if (other.tag == "elseTag")
        {
            moveSpeed = normalSpeed;
        }
    }
}
