using UnityEngine;
using System.Collections;

public class Pet : MonoBehaviour
{

    private GameObject petAI;
    public float moveSpeed = 2f;

    private float dist;

    void Awake()
    {
        petAI = GameObject.FindGameObjectWithTag("Player");
    }

    void Start()
    {

    }

    void Update()
    {
        dist = Vector2.Distance(petAI.transform.position, transform.position);

        if (dist < 20 && dist >= 1.2)
        {
            transform.LookAt(petAI.transform);

            transform.position = Vector2.MoveTowards(transform.position, petAI.transform.position, moveSpeed * Time.deltaTime);
        }
    }
}