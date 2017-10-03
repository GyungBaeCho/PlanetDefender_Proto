﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    private List<GameObject>    _lstBullet;
    private float               _fireTimer;

    public float                _fireRate;
    public GameObject           _bulletPrefab;

    // Use this for initialization
    void Start () {
        _lstBullet = new List<GameObject>();

        _fireTimer = Random.Range(0, 1.0f /_fireRate);
    }
	
	// Update is called once per frame
	void Update ()
    {
        _fireTimer += Time.deltaTime;
        if (_fireTimer > 1/_fireRate)
        {
            GameObject newBullet = Instantiate(_bulletPrefab, transform.position, transform.rotation);
            //newBullet.transform.parent = gameObject.transform;
         //   _lstBullet.Add(newBullet);

            //fireTimer -= fireRate;
            _fireTimer = 0;
        }

        //for (int i = 0; i < _lstBullet.Count; ++i)
        //{
        //    if (_lstBullet[i] == null)
        //    {
        //        _lstBullet.RemoveAt(i);
        //    }
        //}
    }
}