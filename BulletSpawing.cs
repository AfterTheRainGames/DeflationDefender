using UnityEngine;
using System.Collections;

public class BulletSpawning : MonoBehaviour
{

    public GameObject bulletPrefab;
    private bool shooting = false;
    private Transform player;
    private Coroutine bulletCoroutine;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {

        Vector3 delta = player.position - transform.position;

        if (delta.magnitude <= 20 && !shooting)
        {
            bulletCoroutine = StartCoroutine(bulletTimer());
            shooting = true;
        }
        else if(delta.magnitude > 20 && shooting)
        {
            StopCoroutine(bulletCoroutine);
            shooting = false;
            bulletCoroutine = null;
        }    
    }

    IEnumerator bulletTimer()
    {
        while (true)
        {
            float spawnTimer = Random.Range(1f, 3);
            yield return new WaitForSeconds(spawnTimer);
            SpawnBullet();
        }
    }

    void SpawnBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }
}
