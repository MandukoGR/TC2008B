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
        firingRate = 2f;
        InvokeRepeating("Fire1",delay, firingRate);
        yield return new WaitForSeconds(10f);
        CancelInvoke("Fire1");
        yield return new WaitForSeconds(10f);
        firingRate = 3f;
        InvokeRepeating("Fire2", delay, firingRate);
        yield return new WaitForSeconds(10f);
        CancelInvoke("Fire2");
        // InvokeRepeating("Fire3", delay, firingRate);


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
        GameObject boss = GameObject.Find("Character");

        // Position at the middle of the ship
        Vector3 startPosition = transform.position + new Vector3(2, 0.5f, 0);

        projectile.GetComponent<MoveProjectile>().speed = projectileSpeed;
        projectile.GetComponent<MoveProjectile>().angle = angle;
        // Instantiate the projectile at the position and rotation of this transform
        bulletCount++;
        GameObject beam = Instantiate(projectile, startPosition, transform.rotation);
        beam.transform.LookAt(boss.transform);
        
   

        // Same thing, but for the left position
        startPosition = transform.position + new Vector3(-2, 0.5f, 0);
        bulletCount++;
        beam = Instantiate(projectile, startPosition, transform.rotation);
        beam.transform.LookAt(boss.transform);
      


        // Same thing, but to front position
        startPosition = transform.position + new Vector3(0, 0.5f, 2);
        bulletCount++;
        beam = Instantiate(projectile, startPosition, transform.rotation);
        beam.transform.LookAt(boss.transform);
      

        // Same thing, but to back position
        startPosition = transform.position + new Vector3(0, 0.5f, -2);
        bulletCount++;
        beam = Instantiate(projectile, startPosition, transform.rotation);
        beam.transform.LookAt(boss.transform);
     

    }

    void Fire2()
    {
        angle = 0f;
        GameObject boss = GameObject.Find("Character");

        // generate projectiles all around the boss
        for (int i = 0; i < 360; i += 45)
        {
            // Position at the middle of the ship
            Vector3 startPosition = transform.position + new Vector3(2, 0.5f, 0);

            projectile.GetComponent<MoveProjectile>().speed = projectileSpeed;
            projectile.GetComponent<MoveProjectile>().angle = angle;
            // Instantiate the projectile at the position and rotation of this transform
            bulletCount++;
            GameObject beam = Instantiate(projectile, startPosition, transform.rotation);
            beam.transform.LookAt(boss.transform);
            beam.transform.Rotate(0, i, 0);
        
        }
    }

}
