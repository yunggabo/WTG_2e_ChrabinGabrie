using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTriggerDetection : MonoBehaviour
{
    public PlayerScore score;
    public PlayerHealth health;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Spikes")
        {
            health.TakeDamage();
        }
        if (other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (other.CompareTag("Checkpoint"))
        {
            CheckpointManager checkpointManager = GameObject.FindObjectOfType<CheckpointManager>();
            checkpointManager.SetCheckpoint(other.gameObject);
        }
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            score.AddPoint();
        }
    }
}
