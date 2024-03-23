using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesController : MonoBehaviour
{
    public float speed;
    public Transform DespawnPoint;
    public Transform SpawnPoint;

    private void Start()
    {
        
    }


    void Update()
    {
        transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);

        if(transform.position.x > DespawnPoint.position.x)
        {
            transform.position = new Vector3(SpawnPoint.position.x, transform.position.y, transform.position.z);
        }
    }
}
