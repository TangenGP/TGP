using UnityEngine;
using System.Collections;

public class DamageStein : MonoBehaviour
{
    public float damage = 10f;
    // Update is called once per frame

    void OnTriggerEnter2D(Collider2D other)
    {
        damage = Mathf.Round(Random.Range(damage,damage));
        other.gameObject.GetComponent<Health>().TakeDamage(damage);
    }
}