using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    private GameObject enemyAI;
    private Vector3 startPos;
    private float dist;

    public float moveSpeed = 2f;
    

    

    void Awake()
    {
        enemyAI = GameObject.FindGameObjectWithTag("Player");
        startPos = transform.position;
    }

	void Start ()
    {
	
	}
	
	void Update ()
    {
        dist = Vector3.Distance(enemyAI.transform.position, transform.position);

        if(dist < 7 && dist >= 2)
        {
            transform.LookAt(enemyAI.transform);

            transform.position = Vector2.MoveTowards(transform.position, enemyAI.transform.position, moveSpeed * Time.deltaTime);
        }

        else
        {
            transform.LookAt(startPos);

            transform.position = Vector3.MoveTowards(transform.position, startPos, moveSpeed * Time.deltaTime);
        }
	}
}
