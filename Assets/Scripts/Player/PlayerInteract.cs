using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
  private Camera cam;
  // TODO research more 
  [SerializeField]
  private float distance = 3f;
  [SerializeField]
  private LayerMask mask;
  private PlayerUi playerUi;
  private InputManager inputManager;

  void Start()
  {
    cam = GetComponent<PlayerLook>().cam;
    playerUi = GetComponent<PlayerUi>();
    inputManager = GetComponent<InputManager>();
  }

  // Update is called once per frame
  void Update()
  {

    playerUi.UpdateText(string.Empty);

    Ray ray = new Ray(cam.transform.position, cam.transform.forward);
    // INFO usefully debugging 
    Debug.DrawRay(ray.origin, ray.direction * distance);
    RaycastHit hitInfo;
    // ray casting to the center of the screen
    if (Physics.Raycast(ray, out hitInfo, distance, mask))
    {
      // check if the object has an interactable component 
      Interactable interactable = hitInfo.collider.GetComponent<Interactable>();
      if (interactable != null)
      {
        playerUi.UpdateText(interactable.promptMessage);
        // interact with the object by pressing a key
        if (inputManager.onFoot.Interact.triggered)
        {
          interactable.BaseInteract();
        }
      }
    }
  }
}
