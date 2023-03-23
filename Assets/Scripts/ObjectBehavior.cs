using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehavior : MonoBehaviour
{
    [SerializeField] GameObject _prefabs;
    public void Spawn() => Instantiate(_prefabs, new Vector3(Random.Range(-7f, 7f), 5f, 0f), Quaternion.identity);
    private void OnCollisionEnter2D(Collision2D collision) {
        Spawn();
        Destroy(gameObject);
    }
}
