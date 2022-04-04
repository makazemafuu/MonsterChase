using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterFollow : MonoBehaviour
{
    public float speed;

    private Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
