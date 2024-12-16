using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3;
    public GameObject gameoverScreen;
    public GameObject[] healthArray;



    public void TakeDamage()
    {
        this.gameObject.SetActive(false);
        health--;
        for(int i = 0; i < healthArray.Length; i++)
        {
            if(i >= health)
            {
                healthArray[i].SetActive(false);
            }
            else
            {
                healthArray[i].SetActive(true);
            }


        }
        if(health>0)
        {
            CheckpointManager checkpointManager = GameObject.FindObjectOfType<CheckpointManager>();
            checkpointManager.RespawnPlayer(gameObject);
        }
        else
        {
            Die();
        }
    }

    void Die()
    {
        gameoverScreen.SetActive(true);
    }
}
