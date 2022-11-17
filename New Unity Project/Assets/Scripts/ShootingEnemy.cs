using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    public GameObject projectile;
    public float projectileSpeed = 10f;
    public float firingRate = 0.2f;
    private float delay = 0.2f;

  

    IEnumerator Start()
    {
       InvokeRepeating("Fire1",delay, firingRate);
        yield return new WaitForSeconds(3f);
        CancelInvoke("Fire1");
        // InvokeRepeating("Fire2", delay, firingRate);
        // yield return new WaitForSeconds(3f);
        // CancelInvoke("Fire2");
        // InvokeRepeating("Fire3", delay, firingRate);


    }
    void Fire1()
    {
        Vector3 startPosition = transform.position + new Vector3(0, -1, 0);
        projectile.GetComponent<MoveProjectile>().speed = projectileSpeed;
        Instantiate(projectile, startPosition, Quaternion.identity);
        

    }

}
