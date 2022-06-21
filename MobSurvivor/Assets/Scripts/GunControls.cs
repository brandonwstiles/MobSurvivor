using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControls : MonoBehaviour
{
    public Transform SpawnLocation;
    public GameObject bullet;
    public float cooldown = .5f;

    private void Start()
    {
        StartCoroutine(WeaponCooldown(cooldown));
    }
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        transform.right = mousePos - (Vector2)transform.position; 
    }

    void FireWeapon(GameObject bullet)
    {
        Instantiate(bullet, SpawnLocation.position, SpawnLocation.rotation);
    }

    IEnumerator WeaponCooldown(float seconds)
    {
        while(true)
        {
                FireWeapon(bullet);
                yield return new WaitForSeconds(seconds);
        }
    }
}
