using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuyDamage : MonoBehaviour
{
    public GameObject DeathDisplayPrefab;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerBullet") {
            GameObject go = Instantiate(DeathDisplayPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(go, 2);
        }
    }
}
