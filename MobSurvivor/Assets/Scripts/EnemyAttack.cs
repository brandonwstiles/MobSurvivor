using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject player;
    public bool isPlayer;
    public Health playerhealth;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerhealth = player.GetComponent<Health>();
        StartCoroutine(AttackCooldown());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isPlayer = true;
        }
    }
    
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isPlayer = false;
        }
    }

    private IEnumerator AttackCooldown()
    {
        while (true)
        {
            if (isPlayer)
            {
                playerhealth.TakeDamage(5);
            }
            yield return new WaitForSeconds(.3f);
        }
    }
}
