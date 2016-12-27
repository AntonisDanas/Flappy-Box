using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public int playerPoints;
    public GameObject player;
    public GameObject mainCamera;
    public GameObject columnManager;
    public GameObject startPanel;
    public GameObject scorePanel;
    public GameObject endPanel;

    private ColumnSpawner columnSpawner;
    private CameraMovement cameraMovement;
    private BirdController birdController;
    private ScoreText scoreText;
    private FinalScoreText finalScoreText;
    private bool isPlaying;

    private void Start() {

        birdController = player.GetComponent<BirdController>();
        cameraMovement = mainCamera.GetComponent<CameraMovement>();
        columnSpawner = columnManager.GetComponent<ColumnSpawner>();
        scoreText = scorePanel.GetComponentInChildren<ScoreText>();
        finalScoreText = endPanel.GetComponentInChildren<FinalScoreText>();

        startPanel.SetActive(true);
        scorePanel.SetActive(false);
        endPanel.SetActive(false);

        playerPoints = 0;
        isPlaying = false;

        IdleMode();

    }

    public void StartPlaying() {
        Debug.Log("GameController: Start Playing");
        isPlaying = true;
        birdController.StartMoving();
        cameraMovement.StartFollowing();
        columnSpawner.StartSpawning();
        startPanel.SetActive(false);
        scorePanel.SetActive(true);
        scoreText.UpdateScore(0);
    }

    public void StopPlaying() {
        Debug.Log("GameController: Stop Playing");
        if (isPlaying) {
            isPlaying = false;
            birdController.Die();
            cameraMovement.StopFollowing();
            columnSpawner.StopSpawning();
            scorePanel.SetActive(false);
            endPanel.SetActive(true);
            finalScoreText.SetFinalScore(playerPoints);
        }
    }

    private void IdleMode() {
        Debug.Log("GameController: Idle Mode");
        birdController.SetIdling();
        isPlaying = false;

    }

    public void ScorePoint() {
        playerPoints++;
        scoreText.UpdateScore(playerPoints);
    }
}
