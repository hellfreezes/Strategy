using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    [SerializeField]
    private Storage storage;

    private List<Building> buildings;

	// Use this for initialization
	void Start () {
        buildings = new List<Building>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
