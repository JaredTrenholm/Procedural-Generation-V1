using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject player;
    public CharacterController playerCC;

    public void SpawnPlayer()
    {
        playerCC.enabled = false;
        player.transform.position = this.gameObject.transform.position;
        playerCC.enabled = true;
    }
}
