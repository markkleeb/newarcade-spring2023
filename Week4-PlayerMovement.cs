using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 movement;
    public float speed = 10.0f;

    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Hz", movement.x);
        animator.SetFloat("Vt", movement.y);

        transform.Translate(movement * speed * Time.deltaTime);
    }
}
