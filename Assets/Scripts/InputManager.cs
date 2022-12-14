using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
  public PlayerInput.OnFootActions onFoot;

  private PlayerInput playerInput;
  private PlayerMotor motor;
  private PlayerLook look;



  // Start is called before the first frame update
  void Awake()
  {
    playerInput = new PlayerInput();
    onFoot = playerInput.OnFoot;
    motor = GetComponent<PlayerMotor>();
    look = GetComponent<PlayerLook>();
    // ctx = "callback context" to jump function 
    onFoot.Jump.performed += ctx => motor.Jump();
  }

  // Update is called once per frame
  void FixedUpdate()
  {
    motor.processMove(onFoot.Movement.ReadValue<Vector2>());
  }

  private void LateUpdate()
  {
    look.processLook(onFoot.Look.ReadValue<Vector2>());
  }

  private void OnEnable()
  {
    onFoot.Enable();
  }
  private void OnDisable()
  {
    onFoot.Disable();
  }
}
