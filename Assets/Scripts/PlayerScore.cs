using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScore : MonoBehaviour
{
    public TMP_Text scoreText;
    private int coins;

    public void AddPoint()
    {
        coins++;
        scoreText.text = coins.ToString();
    }
}
