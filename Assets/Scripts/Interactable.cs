using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
  public string promptMessage;

  public void BaseInteract()
  {
    Interact();
  }

  protected virtual void Interact()
  {
    // this is a template function to be overwritten by our subclasses
  }
}

