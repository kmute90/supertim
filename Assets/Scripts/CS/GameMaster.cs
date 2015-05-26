using UnityEngine;
using System.Collections;

namespace Assets.Scripts.CS
{
    public enum GameState
    {
        LevelView = 2,
        GameView = 3
    }

    public class GameMaster : MonoBehaviour
    {
        public static int currentScore = 0;
        public static int currentLife = 5;
        public static int currentLevel = 1;
        public GameState currentGameState;

        public bool IsGameView
        {
            get { return currentGameState == GameState.GameView; }
        }
        public bool IsLevelView
        {
            get { return currentGameState == GameState.LevelView; }
        }

        private float offsetY = 40;
        private float sizeX = 100;
        private float sizeY = 40;

        public void Start()
        {
            Screen.orientation = ScreenOrientation.LandscapeLeft;
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
            //Debug.Log("GameMaster start");
        }

        //private int updateCntr = 0;
        public void Update()
        {
            //Debug.Log("updateCntr: " + updateCntr++);
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.LoadLevel(0);
                currentLevel = 1;
            }
        }

        //private int guiCntr = 0;
        public void OnGUI()
        {
            //Debug.Log("guiCntr: " + guiCntr++);
            if (IsGameView)
            {
                GUI.Box(new Rect((Screen.width/2 - sizeX/2) - 100, offsetY, sizeX, sizeY), "Score: " + currentScore);
                GUI.Box(new Rect((Screen.width/2 - sizeX/2) + 100, offsetY, sizeX, sizeY), "Life: " + currentLife);
            }
            else if (IsLevelView)
            {
                guiText.text = "Level " + currentLevel;
            }
        }

        public static void InitLevel()
        {
            Application.LoadLevel("levelView");
            currentLife = 5;
            currentScore = 0;
        }
    }
}