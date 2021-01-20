/* using System;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float Speed = 0.2f;

    private DateTime _nextChangeTime = DateTime.Now;
    private Vector3 _orientation = Vector3.right;

    void Update()
    {
        if (_nextChangeTime < DateTime.Now)
        {
            _orientation = new Vector3(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f), 0).normalized;
            _nextChangeTime = DateTime.Now.AddSeconds(1);
        }

        transform.position = transform.position + _orientation * (Speed * Time.deltaTime);
        transform.localEulerAngles = new Vector3(0, 0, Mathf.Rad2Deg * Mathf.Atan2(_orientation.y, _orientation.x));
    }
} */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveBall : MonoBehaviour
{
    public float Speed = 3;
    public float ShapeRecoverRate = 0.05f;

    public GameObject effect;

    private DateTime now = DateTime.Now;
    private Vector3 direction = Vector3.right;
    private Rigidbody2D rigidbody2D;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rigidbody2D.rotation = Mathf.Rad2Deg * Mathf.Atan2(rigidbody2D.velocity.y, rigidbody2D.velocity.x);
    }

    private void OnCollisionEnter2D(Collision2D other){
       Instantiate(effect, (Vector3) other.contacts[0].point, Quaternion.identity);
    }
}
