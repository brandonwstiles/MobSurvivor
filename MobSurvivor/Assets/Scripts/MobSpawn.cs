using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobSpawn : MonoBehaviour
{

    private GameObject _player;
    private Vector2 _screenBounds;
    private Vector3 _enemyOffset;

    public GameObject mob;
    void Awake()
    {
       _player  = GameObject.FindGameObjectWithTag("Player");
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Countdown2());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Countdown2()
    {
        while (true)
        {
            yield return new WaitForSeconds(.1f);
            SpawnMob(mob,Random.Range(1, 5));
        }
    }

    void SpawnMob(GameObject mob, int screenEdge)
    {
        switch (screenEdge)
        {
            case 1:
                _enemyOffset = Camera.main.ViewportToWorldPoint(new Vector3(.99f, Random.Range(0f, 1f), 2));
                break;
            case 2:
                _enemyOffset = Camera.main.ViewportToWorldPoint(new Vector3(.01f, Random.Range(0f, 1f), 2));
                break;
            case 3:
                _enemyOffset = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(0f, 1f), .99f, 2));
                break;
            case 4:
                _enemyOffset = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(0f, 1f), .01f, 2));
                break;
        }
        //_enemyOffset = Camera.main.ViewportToWorldPoint(new Vector3(1f, Random.Range(0f, 1f),0f));
        //_enemyOffset.x = _player.transform.position.x + Random.Range(-2.0f, 2.0f);
        //_enemyOffset.y = _player.transform.position.y + Random.Range(-2.0f, 2.0f);
        //_enemyOffset.z = 0;

        GameObject.Instantiate(mob, _enemyOffset,Quaternion.identity);
    }
}
