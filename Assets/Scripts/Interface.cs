using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interface : MonoBehaviour {

    [SerializeField]
    private List<Text> txtResource;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void UpdateResourceText(GatheringResource res, string value)
    {
        txtResource[(int)res].text = value;
    }
}
