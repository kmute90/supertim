using UnityEngine;
using System.Collections;

namespace Assets.Scripts.CS
{
    public class FinishController : MonoBehaviour
    {
        public bool IsEndGame = false;
        // Use this for initialization
        public void OnCollisionEnter2D(Collision2D coll)
        {
            if (IsEndGame)
            {
                Application.LoadLevel("finish");
                GameMaster.currentLevel = 1;
            }
            else
            {
                GameMaster.currentLevel++;
                Application.LoadLevel("levelView");
            }
        }
    }
}
