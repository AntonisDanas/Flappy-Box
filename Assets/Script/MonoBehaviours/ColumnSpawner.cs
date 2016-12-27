using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner : MonoBehaviour {

    public float columnSpacing;
    public GameObject columnPairPrefab;
    public GameObject player;
    public float maxColumnHeight;
    //the max distance from the player that we should spawn a column pair
    public float spawnDistanceFromPlayer;

    private bool isSpawning;
    private int columnsSpawned;

    private void Start() {
        isSpawning = false;
        columnsSpawned = 0;
    }

    private void Update() {
        if (isSpawning && ShouldSpawnColumn()) {
            SpawnColumn();
        }
    }

    public void StartSpawning() {
        Debug.Log("ColumnSpawner: Start Spawning");
        isSpawning = true;
    }

    public void StopSpawning() {
        Debug.Log("ColumnSpawner: Stop Spawning");
        isSpawning = false;
    }

    private bool ShouldSpawnColumn() {
        float spawnThreshold;
        spawnThreshold = player.transform.position.x + spawnDistanceFromPlayer;
        if (columnsSpawned * columnSpacing < spawnThreshold) {
            return true;
        }
        return false;
    }

    private void SpawnColumn() {
        Debug.Log("ColumnSpawner: Spawn Column");
        float xposition = columnsSpawned * columnSpacing;
        float yposition = Random.Range(-maxColumnHeight, maxColumnHeight);
        Vector3 columnPosition = new Vector3(xposition, yposition, 0f);
        GameObject columnPair = Instantiate(columnPairPrefab, columnPosition, Quaternion.identity) as GameObject;
        columnPair.transform.SetParent(this.gameObject.transform);
        columnsSpawned++;
    }

}
