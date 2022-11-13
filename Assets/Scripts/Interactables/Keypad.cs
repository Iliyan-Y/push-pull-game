using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : Interactable
{
  [SerializeField]
  private GameObject keypad;
  private bool isOpen = false;

  protected override void Interact()
  {
    base.Interact();
  }
}
