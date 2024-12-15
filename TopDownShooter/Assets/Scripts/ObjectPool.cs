using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool objectPool { get; private set; }

    private List<GameObject> objects = new List<GameObject>();
    private int amountToPool = 30;

    [SerializeField] private GameObject objectToPool;

    private void Awake()
    {
        if (objectPool == null)
        {
            objectPool = this;
        }
    }

    private void Start()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = Instantiate(objectToPool);
            obj.SetActive(false);
            objects.Add(obj);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < objects.Count; i++)
        {
            if (!objects[i].activeInHierarchy)
            {
                return objects[i];
            }
        }

        GameObject obj = Instantiate(objectToPool);
        obj.SetActive(false);
        objects.Add(obj);
        return obj;
    }

}
