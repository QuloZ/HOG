﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ItemMouseClick), typeof(Light))]
public class Item : MonoBehaviour
{
    [SerializeField] private string _name;
    [SerializeField] private bool floor;
    [SerializeField] private bool wall;
    [SerializeField] private bool roof;
    [SerializeField] private bool box;

    private EmptySpace _space;

    public void ItemRotate()
    {
        _space = transform.parent.GetComponent<EmptySpace>();
        Vector3 angle = _space.GetSideRotation();        
        transform.rotation = Quaternion.Euler(angle);
    }
    public void BackLight()
    {
        GetComponent<Light>().range = 0.1f;
        StartCoroutine(StartLight());
    }
    IEnumerator StartLight()
    {       
        yield return new WaitForSeconds(3f);
        GetComponent<Light>().range = 0;
    }

    public string Name { get { return _name; } }
    public bool Floor { get {return floor; } }
    public bool Wall { get { return wall; } }
    public bool Roof { get { return roof; } }
    public bool Box { get { return box; } }

}
