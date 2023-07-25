using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bulletSpawned;
    public GameObject shootPoint;
    public GameObject cannonShooter;

    public float attackSpeed = 1;

    public GameObject balloon;

    // Start is called before the first frame update
    void Start()
    {
        if(balloon != null)StartCoroutine("ShootBullet");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ShootBullet()
    {
        bulletSpawned = Instantiate(bullet, shootPoint.transform.position, cannonShooter.transform.rotation) as GameObject;

        yield return new WaitForSeconds(attackSpeed);

        if (balloon != null) StartCoroutine(ShootBullet());
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Balloon")
        {
            balloon = other.gameObject;

            cannonShooter.GetComponent<LookAtBallon>().AssignBalloon(other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        cannonShooter.GetComponent<LookAtBallon>().AssignBalloon(null);
    }
}
