using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public TextMeshProUGUI healthText;

    // Start is called before the first frame update
    void Start()
    {
      healthText.text = "Health:" + health;
    }

    public void UpdateHealth(int healthChange)
    {
        health -= healthChange;
        healthText.text = "Health:" + health;

    }

}
