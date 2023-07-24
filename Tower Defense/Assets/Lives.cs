using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public int lives;

    public Material[] colors;
    public float[] sizes;
    public int[] lifeRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        lives -= damage;

        /*if(lives < 30 && lives >= 20)
        {
            gameObject.GetComponent<MeshRenderer>().material = colors[10];
        }*/
    }
}
