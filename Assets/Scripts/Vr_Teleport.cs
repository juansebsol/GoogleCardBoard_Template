using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Vr_Teleport : MonoBehaviour
{

    public GameObject player;

    public void TeleportPlayer() 
    {
        player.transform.position = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);
    }
}
