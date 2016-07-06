using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public Image healthBar;
    public float max_health = 100f;
    public float cur_health = 0f;
    public bool alive = true;

	// Use this for initialization
	void Start ()
    {
        //FloatingTextController.Initialize();
        alive = true;
        cur_health = max_health;
        SetHealthBar();    
	}

    void DoDamage()
    {
        TakeDamage(10f);
    }

    public void TakeDamage(float amount)
    {
        if (cur_health <= 0)
        {
            cur_health = 0;
            alive = false;
        }
        /*if (cur_health <= max_health)
        {
            this.TakeDamage();
        }*/

        cur_health -= amount;
        SetHealthBar();


    }

	void Update()
    {
        if (!alive)
        {
            Destroy(gameObject);
        }

    }
    void SetHealthBar ()
    {
        float my_health = cur_health / max_health;
        healthBar.transform.localScale = new Vector3(Mathf.Clamp(my_health, 0f, 1f), healthBar.transform.localScale.y, healthBar.transform.localScale.z);
	}
}
