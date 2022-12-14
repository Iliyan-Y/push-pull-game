using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
  public Camera cam;
  private float xRotation = 0f;

  public float xSensitivity = 20f;
  public float ySensitivity = 20f;

  public void processLook(Vector2 input)
  {
    float mouseX = input.x;
    float mouseY = input.y;
    // calculate camera for looking up and down 
    xRotation -= (mouseY * Time.deltaTime) * ySensitivity;
    xRotation = Mathf.Clamp(xRotation, -80f, 80f);
    cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
    // rotate the player lef and right 
    transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity);
  }
}
