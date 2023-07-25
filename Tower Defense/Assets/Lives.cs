using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public int lives;

    public Material[] colors;
    public float[] sizes;
    public int[] lifeMinimum;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < lifeMinimum.Length; i++)
        {
            if (lives > lifeMinimum[i])
            {
                ApplyBallon(i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        print("aua");
        lives -= damage;

        /*if(lives < 500 && lives >= 300)
        {
            gameObject.GetComponent<MeshRenderer>().material = colors[10];
        }
        if (lives < 299 && lives >= 200)
        {
            gameObject.GetComponent<MeshRenderer>().material = colors[9];
        }
        if (lives < 199 && lives >= 150)
        {
            gameObject.GetComponent<MeshRenderer>().material = colors[8];
        }
        if (lives < 149 && lives >= 120)
        {
            gameObject.GetComponent<MeshRenderer>().material = colors[7];
        }
        if (lives < 119 && lives >= 100)
        {
            gameObject.GetComponent<MeshRenderer>().material = colors[6];
        }
        if (lives < 99 && lives >= 50)
        {
            gameObject.GetComponent<MeshRenderer>().material = colors[5];
        }
        if (lives < 49 && lives >= 30)
        {
            gameObject.GetComponent<MeshRenderer>().material = colors[4];
        }
        if (lives < 29 && lives >= 15)
        {
            gameObject.GetComponent<MeshRenderer>().material = colors[3];
        }
        if (lives < 14 && lives >= 6)
        {
            gameObject.GetComponent<MeshRenderer>().material = colors[2];
        }
        if (lives < 5 && lives >= 3)
        {
            gameObject.GetComponent<MeshRenderer>().material = colors[1];
        }
        if (lives < 2 && lives >= 1)
        {
            ApplyBallon1();
        }*/

        for(int i = 0; i < lifeMinimum.Length; i++)
        {
            if(lives > lifeMinimum[i])
            {
                ApplyBallon(i);
            }
        }
    }
    public void ApplyBallon(int number)
    {
        gameObject.GetComponent<MeshRenderer>().material = colors[number];
        gameObject.transform.localScale = new Vector3(sizes[number], sizes[number], sizes[number]);
    }
}
