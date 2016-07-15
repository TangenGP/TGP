using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{
    public float fireRate = 0;
    public LayerMask whatToHit;

    public Transform BulletTrailPrefab;

    float timeToSpawnEffect = 0;
    public float effectSpawnRate = 10;
    float timeToFire = 0;
    Transform firePoint;

    [SerializeField]
	private int laserAmmo;
    [SerializeField]
    private int laserSkuddKjop = 500;
    [SerializeField]
    private int laserShot;

    public GameObject gunDeactivation;
	public Text ammunitionTextX1;
	//public Text ammunitionTextX2;
	//public Text ammunitionTextX3;

	void Start ()
	{
		laserAmmo = 500;
		gunDeactivation.gameObject.SetActive (true);
		ammunitionTextX1.text = laserAmmo.ToString();
		//ammunitionTextX2.text = laserAmmo.ToString();
		//ammunitionTextX3.text = laserAmmo.ToString();
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
		if (laserAmmo <= 0)
		{
			gunDeactivation.gameObject.SetActive(false);
		}
		else
		{
			laserAmmo -= laserShot;
			ammunitionTextX1.text = laserAmmo.ToString();
			//ammunitionTextX2.text = laserAmmo.ToString();
			//ammunitionTextX3.text = laserAmmo.ToString();
		}
	}

    void Effect()
    {
        Instantiate(BulletTrailPrefab, firePoint.position, firePoint.rotation);
        //BulletTrailPrefab.name = "pew";
    }

	public void addAmmunition(int ammunitionGained)
	{
			laserAmmo += ammunitionGained;
			ammunitionTextX1.text = laserAmmo.ToString();
			//ammunitionTextX2.text = laserAmmo.ToString();
			//ammunitionTextX3.text = laserAmmo.ToString();
	}
}
