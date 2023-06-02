using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShooting : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform FirePlace;
    public float BulletForce;
    private float nextActionTime = 4f;
    private float timePeriod = 4f;
    private int cannonIndex = 1;
    public int thisIndex;
    private bool isShooting = false;
    private void Awake()
    {
        cannonIndex = 1;
        isShooting = false;
    }

    void Update()
    {
        if (cannonIndex == 5)
        {
            cannonIndex = 1;
        }
        if (Time.time > nextActionTime)
        {
            nextActionTime += timePeriod;
            isShooting = true;
            StartCoroutine("FireBullet");
            cannonIndex++;
            timePeriod = timePeriod - 0.033f;

        }
    }

    // Update is called once per frame


    private IEnumerator FireBullet()
    {
        if (thisIndex == cannonIndex)
        {
            while (isShooting == false)
            {
                yield return null;
            }
            GameObject Bullet = Instantiate(BulletPrefab, FirePlace.position, FirePlace.rotation);
            Rigidbody rb = Bullet.GetComponent<Rigidbody>();
            rb.AddForce(FirePlace.forward * BulletForce, ForceMode.Impulse);
            yield return new WaitForSeconds(5f);
            Destroy(Bullet);
        }
    }
}
