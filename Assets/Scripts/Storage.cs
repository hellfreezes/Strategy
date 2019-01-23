using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour {
    private Dictionary<GatheringResource, int> storage;

	// Use this for initialization
	void Start () {
        storage = new Dictionary<GatheringResource, int>();
        storage.Add(GatheringResource.WOOD, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnResourceExtracted(object obj, EventArgs args)
    {
        Building b = (Building)obj;
        AddResource(b.GetResourceType(), b.ResourceAtATime);
    }

    private void AddResource(GatheringResource res, int value)
    {
        if (storage.ContainsKey(res))
        {
            storage[res] += value;
        } else
        {
            Debug.LogError("В хранилище отсутсвует ресурс " + res.ToString());
        }
    }
}
