using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour
{
    public float speed = 0f;
    public float angle = 0f;
    public float secondsToDestroy = 0f;
    private GameObject boss;
    // get boss gameobject

    // Start is called before the first frame update
    void Start()
    {
        boss = GameObject.Find("Character");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        StartCoroutine(RotateProjectile());
        StartCoroutine(destroyBullet());
        
    }
    IEnumerator destroyBullet()
    {
        yield return new WaitForSeconds(secondsToDestroy);
        Destroy(gameObject);
        boss.GetComponent<ShootingEnemy>().bulletCount--;
    }
  
    IEnumerator RotateProjectile()
    {
        yield return new WaitForSeconds(3f);
        transform.Rotate(Vector3.up * Time.deltaTime * angle);
        
    }
    
}
