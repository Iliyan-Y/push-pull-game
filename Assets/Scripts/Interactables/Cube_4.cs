using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_4 : Interactable
{
  [SerializeField]
  private GameObject cube4;
  private bool isRotating = false;
  protected override void Interact()
  {
    isRotating = !isRotating;
    cube4.GetComponent<Animator>().SetBool("IsRotating", isRotating);
  }
}
