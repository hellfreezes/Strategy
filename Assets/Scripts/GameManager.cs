using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    [SerializeField]
    private Storage storage;

    [SerializeField]
    private List<GameObject> buildingPrefabs;

    private List<Building> buildings;

	// Use this for initialization
	void Start () {
        buildings = new List<Building>();

        // Временный колхоз. Устанавливаем тестовое строение
        PlaceBuilding(0, new Vector3(2.5f, .5f, 2.5f));

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void PlaceBuilding(int index, Vector3 position)
    {
        GameObject newBuildingGO = Instantiate(buildingPrefabs[index], position, Quaternion.identity);
        Building newBuilding = newBuildingGO.GetComponent<Building>();

        buildings.Add(newBuilding);
        newBuilding.ResourceExtracted += storage.OnResourceExtracted;
    }
}
