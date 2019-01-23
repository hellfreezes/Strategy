using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GatheringResource
{
    WOOD = 1
};

public class Building : MonoBehaviour {

    [SerializeField]
    private GatheringResource resource;
    [SerializeField]
    private int resourceAtATime = 1;
    [SerializeField]
    private float gatheringTime;

    private float counter = 0;

    public int ResourceAtATime
    {
        get
        {
            return resourceAtATime;
        }
    }

    public event EventHandler ResourceExtracted;
    
    public GatheringResource GetResourceType()
    {
        return resource;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ExtractResource();

    }

    private void ExtractResource ()
    {
        counter += Time.deltaTime;
        if (counter >= gatheringTime)
        {
            counter = 0;
            OnResourceExtracted();
        }
    }

    protected virtual void OnResourceExtracted()
    {
        if (ResourceExtracted != null)
        {
            ResourceExtracted(this, EventArgs.Empty);
        }
    }
}
