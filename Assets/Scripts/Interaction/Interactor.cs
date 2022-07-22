using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactor : Singleton<Interactor>
{
    private Camera cam;
    private Transform camTrans;

    public LayerMask interactLayer;
    private Interactable currentInteractObj;
    public Image cursorPointImg;
    private Grabblable currentGrabbleObj;
    public float raycastLength = 8;


    public Transform handTrans;
    private void Start()
    {
        cursorPointImg.color = Color.white;
        cam = Camera.main;
        camTrans = cam.transform;
    }
    // Update is called once per frame
    void Update()
    {
        if (!currentGrabbleObj)
        {
            RaycastHit hit;
            if (Physics.Raycast(camTrans.position, camTrans.forward, out hit, raycastLength, interactLayer))
            {
                Interactable interactObj = hit.collider.GetComponent<Interactable>();
                if (interactObj != null)
                {
                    cursorPointImg.color = Color.black;

                    if (currentInteractObj == null)
                    {
                        currentInteractObj = interactObj;
                        currentInteractObj.OnInteract();
                    }
                    else
                    {
                        if (currentInteractObj.gameObject != interactObj.gameObject)
                        {
                            currentInteractObj.OnRelease();
                            currentInteractObj = interactObj;
                            currentInteractObj.OnInteract();
                        }
                        else
                        {

                        }
                    }
                }
                else
                {
                    cursorPointImg.color = Color.white;
                    if (currentInteractObj)
                    {
                        currentInteractObj.OnRelease();
                    }
                    currentInteractObj = null;
                }
            }
            else
            {
                cursorPointImg.color = Color.white;
                if (currentInteractObj)
                {
                    currentInteractObj.OnRelease();
                }
                currentInteractObj = null;
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (currentInteractObj != null)
            {
                Grabblable grabblable = currentInteractObj.GetComponent<Grabblable>();
                if (grabblable != null)
                {
                    currentInteractObj.OnRelease();
                    currentInteractObj = null;
                    if (currentGrabbleObj == null)
                    {
                        currentGrabbleObj = grabblable;
                        currentGrabbleObj.OnGrabble(handTrans);
                    } else
                    {
                        currentGrabbleObj.OnRelease();
                        currentGrabbleObj = grabblable;
                        currentGrabbleObj.OnGrabble(handTrans);
                    }
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (currentGrabbleObj != null)
            {
                currentGrabbleObj.OnRelease();
                currentGrabbleObj = null;
            }
        }
    }
}
