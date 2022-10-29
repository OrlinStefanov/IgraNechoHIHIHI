using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform bulletRespwnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            var bullet = Instantiate(bulletPrefab, bulletRespwnPoint.position, bulletRespwnPoint.rotation);

            bullet.GetComponent<Rigidbody>().velocity = bulletRespwnPoint.forward * bulletSpeed;
        }
    }

    private void OnMouseUp()
    {

    }
}
