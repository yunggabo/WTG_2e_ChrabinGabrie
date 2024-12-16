using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    public GameObject currentCheckpoint;
    public Color activeColor;
    public Color inactiveColor;

    public void SetCheckpoint(GameObject checkpoint)
    {
        currentCheckpoint.GetComponent<SpriteRenderer>().color = inactiveColor;
        currentCheckpoint.GetComponent<BoxCollider2D>().enabled = false;
        currentCheckpoint = checkpoint;
        currentCheckpoint.GetComponent<SpriteRenderer>().color = activeColor;
    }

    public void RespawnPlayer(GameObject player)
    {
        player.transform.position = currentCheckpoint.transform.position;
        player.SetActive(true);
    }
}
