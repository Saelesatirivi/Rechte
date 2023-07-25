using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtBallon : MonoBehaviour
{
    public GameObject balloon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(balloon != null)transform.LookAt(balloon.transform.position);
    }
    public void AssignBalloon(GameObject balloon)
    {
        this.balloon = balloon;
    }
}
