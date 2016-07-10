using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour
{
    public float fireRate = 0;
    public LayerMask whatToHit;

    public Transform BulletTrailPrefab;

    float timeToSpawnEffect = 0;
    public float effectSpawnRate = 10;
    float timeToFire = 0;
    Transform firePoint;

	public int laserAmmo;
	public int laserSkuddKjop = 1000;
	public int laserShot;
	public GameObject gunDeactivation;

	void Start ()
	{
		laserAmmo = 100;
		laserShot = 1;
		gunDeactivation.gameObject.SetActive (true);
	}

    //use this for initialization
    void Awake ()
    {
        firePoint = transform.FindChild("FirePoint");
        if(firePoint == null)
        {
            Debug.LogError("No firePoint? What?!");
        }
    }

	void Update ()
    {
        if (fireRate == 0)
        {
            if (Input.GetButton("Fire1"))
            {
                Shoot();
				if (laserAmmo <= 0) {
					gunDeactivation.gameObject.SetActive (false);
				} 
				else 
				{
					laserAmmo -= laserShot;
				}
            }
        }
        else
        {
            if (Input.GetButton("Fire1") && Time.time > timeToFire)
            {
                timeToFire = Time.time + 1 / fireRate;
                Shoot();
            }
        }
    }
         
    void Shoot()
    {
        Vector2 mousePosition = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        Vector2 firePointPosition = new Vector2(firePoint.position.x, firePoint.position.y);
        RaycastHit2D hit = Physics2D.Raycast(firePointPosition, mousePosition - firePointPosition, 100, whatToHit);
        if (Time.time >= timeToSpawnEffect)
        {
            Effect();
            timeToSpawnEffect = Time.time + 1 / effectSpawnRate;
        }
    }

    void Effect()
    {
        Instantiate(BulletTrailPrefab, firePoint.position, firePoint.rotation);
        BulletTrailPrefab.name = "pew";
    }

	/*public void laserSkudd()
	{
		laserAmmo += laserSkuddKjop;
	}*/
}
