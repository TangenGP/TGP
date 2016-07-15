using UnityEngine;
using System.Collections;

public class DamageLaser : MonoBehaviour
{
    public bool active = true;
    public float damage;
    // Update is called once per frame

    void OnTriggerEnter2D(Collider2D other)
    {

		damage = Mathf.Round(damage);
		//damage = Mathf.Round(Random.Range(damage, + 5f));
        other.gameObject.GetComponent<Health>().TakeDamage(damage);

        active = false;
        if(!active)
        {
            Destroy(gameObject);
            FloatingTextController.Initialize();
            FloatingTextController.CreateFloatingText(damage.ToString(), transform);
        }
    }
	public void increaseDamage(float increasedDamage)
	{
		damage += increasedDamage;
	}
}