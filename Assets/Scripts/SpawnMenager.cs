using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMenager : MonoBehaviour {
    public GameObject[] animalPrefabs;
    public float rangeX = 24;
    public float rangeY = 24;
    public float startDelay = 2;
    public float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start() {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update() {

    }

    private void SpawnRandomAnimal() {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        var spawnPos = new Vector3(Random.Range(-rangeX, rangeY), 0, 20);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

}
