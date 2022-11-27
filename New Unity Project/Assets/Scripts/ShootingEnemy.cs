using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShootingEnemy : MonoBehaviour
{
    public GameObject projectile;
    private float firingRate;
    private float projectileSpeed = 10f;
    private float angle;
    private float delay = 0.2f;
    public int bulletCount = 0;
    public TextMeshProUGUI text;

  

    IEnumerator Start()
    {
        firingRate = 1f;
        InvokeRepeating("Fire1",delay, firingRate);
        yield return new WaitForSeconds(10f);
        CancelInvoke("Fire1");
        yield return new WaitForSeconds(10f);
        firingRate = 3f;
        InvokeRepeating("Fire2", delay, firingRate);
        yield return new WaitForSeconds(10f);
        CancelInvoke("Fire2");
        yield return new WaitForSeconds(3f);
        firingRate = 0.5f;
        InvokeRepeating("Fire3", delay, firingRate);
        yield return new WaitForSeconds(10f);
        CancelInvoke("Fire3");


    }
    void Update()
    {
        if (bulletCount > 0)
        {
            text.text = "Bullets: " + bulletCount;
        }
        else
        {
            text.text = "Bullets: 0";
        }


    }
    void Fire1()
    {
        angle = 90f;

        // Position at the middle of the ship
        Vector3 startPosition = transform.position + new Vector3(2, 0.5f, 0);

        projectile.GetComponent<MoveProjectile>().speed = projectileSpeed;
        projectile.GetComponent<MoveProjectile>().angle = angle;
        projectile.GetComponent<MoveProjectile>().secondsToDestroy = 10.0f;
        // Instantiate the projectile at the position and rotation of this transform
        bulletCount++;
        GameObject beam = Instantiate(projectile, startPosition, transform.rotation);
        beam.transform.LookAt(this.transform);
        
   

        // Same thing, but for the left position
        startPosition = transform.position + new Vector3(-2, 0.5f, 0);
        bulletCount++;
        beam = Instantiate(projectile, startPosition, transform.rotation);
        beam.transform.LookAt(this.transform);
      


        // Same thing, but to front position
        startPosition = transform.position + new Vector3(0, 0.5f, 2);
        bulletCount++;
        beam = Instantiate(projectile, startPosition, transform.rotation);
        beam.transform.LookAt(this.transform);
      

        // Same thing, but to back position
        startPosition = transform.position + new Vector3(0, 0.5f, -2);
        bulletCount++;
        beam = Instantiate(projectile, startPosition, transform.rotation);
        beam.transform.LookAt(this.transform);
     

    }

    void Fire2()
    {
        angle = 0f;
      

        // generate projectiles all around the boss
        for (int i = 0; i < 360; i += 45)
        {
            // Position at the middle of the ship
            Vector3 startPosition = transform.position + new Vector3(0, 0, 0);

            projectile.GetComponent<MoveProjectile>().speed = projectileSpeed;
            projectile.GetComponent<MoveProjectile>().angle = angle;
            projectile.GetComponent<MoveProjectile>().secondsToDestroy = 5.0f;
            // Instantiate the projectile at the position and rotation of this transform
            bulletCount++;
            GameObject beam = Instantiate(projectile, startPosition, transform.rotation);
            beam.transform.Rotate(0, i, 0);
        
        }
    }

    void Fire3(){

        // Move character forward for a few seconds
        angle = 180f;
        // Position at the middle of the ship
        Vector3 startPosition = transform.position + new Vector3(2, 0.5f, 0);

        projectile.GetComponent<MoveProjectile>().speed = projectileSpeed;
        projectile.GetComponent<MoveProjectile>().angle = angle;
        projectile.GetComponent<MoveProjectile>().secondsToDestroy = 10.0f;
        // Instantiate the projectile at the position and rotation of this transform
        bulletCount++;
        GameObject beam = Instantiate(projectile, startPosition, transform.rotation);
        
   

        // Same thing, but for the left position
        startPosition = transform.position + new Vector3(-2, 0.5f, 0);
        bulletCount++;
        beam = Instantiate(projectile, startPosition, transform.rotation);
      


        // Same thing, but to front position
        startPosition = transform.position + new Vector3(0, 0.5f, 2);
        bulletCount++;
        beam = Instantiate(projectile, startPosition, transform.rotation);
      

        // Same thing, but to back position
        startPosition = transform.position + new Vector3(0, 0.5f, -2);
        bulletCount++;
        beam = Instantiate(projectile, startPosition, transform.rotation);

        
    }

}
