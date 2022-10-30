using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
  private CharacterController controller;
  private Vector3 playerVelocity;
  private bool isGrounded;
  public float speed = 5f;
  public float gravity = -9.8f;
  public float jumpVelocity = 1.4f;

  // Start is called before the first frame update
  void Start()
  {
    controller = GetComponent<CharacterController>();
  }

  // Update is called once per frame
  void Update()
  {
    isGrounded = controller.isGrounded;
  }

  // Receive the input from the InputManager.cs and apply them to  the character controller
  public void processMove(Vector2 input)
  {
    Vector3 moveDirection = Vector3.zero;
    moveDirection.x = input.x;
    moveDirection.z = input.y;
    controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
    playerVelocity.y += gravity * Time.deltaTime;
    if (isGrounded && playerVelocity.y < 0) playerVelocity.y = -2;
    controller.Move(playerVelocity * Time.deltaTime);
  }

  public void Jump()
  {

    if (isGrounded)
    {
      playerVelocity.y = Mathf.Sqrt(jumpVelocity * -3.0f * gravity);
    }
  }


  public void Sprint()
  {
    // TODO
  }

  public void Crouch()
  {
    // TODO
  }

}
