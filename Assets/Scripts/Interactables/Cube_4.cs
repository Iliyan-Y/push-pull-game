using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_4 : Interactable
{
  // Start is called before the first frame update
  protected override void Interact()
  {
    Debug.Log($"Looking at with {gameObject.name}");
  }
}
