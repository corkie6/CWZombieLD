using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject targetTeleporter;
    private Transform targetLocation;
    
    //private CharacterController charController;

    public bool isOneShotTele; // Is this a one-use only teleporter?
    public bool teleUsed;// If it is a one-use tele, has it been used?

    // Start is called before the first frame update
    void Start()
    {
        teleUsed = false;
        targetLocation = targetTeleporter.transform;
        //charController = thePlayer.gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !teleUsed)
        {
            //charController.enabled = false;
            thePlayer.transform.position = targetLocation.position; // move player to target point
            thePlayer.transform.rotation = targetLocation.rotation; // face player same direction as target point
            //charController.enabled = true;
            if (isOneShotTele == true)
            {
                teleUsed = true;
            }

        }
    }
}
