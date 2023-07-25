using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Manager : MonoBehaviour
{
    public int lives;

    public TextMeshProUGUI livesText;

    // Start is called before the first frame update
    void Start()
    {
        livesText.text = lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReduceLives(int damage)
    {
        lives -= damage;

        livesText.text = lives.ToString();
    }
}
