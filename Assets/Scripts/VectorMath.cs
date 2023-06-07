using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMath : MonoBehaviour
{
    public Transform target;
    public float speed;
    public float distance;
    private void Start()
    {
        StartCoroutine(MyCoroutine(target));
    }

    IEnumerator MyCoroutine(Transform target)
    {
        Debug.Log("Starting Coroutine....");

        distance = Vector3.Distance(transform.position, target.position);
        while (distance > 0.1f)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);

            yield return null;
        }

        yield return new WaitForSeconds(3f);

        Debug.Log("Stopped Coroutine...");
    }


    
}
