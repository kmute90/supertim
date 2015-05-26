using UnityEngine;
using System.Collections;

namespace Assets.Scripts.CS
{
    public class CoinPickupManager : MonoBehaviour
    {
        public int coinValue = 1;

        public void OnTriggerEnter2D(Collider2D coll)
        {
            if (coll.gameObject.tag == "Player")
            {
                GameMaster.currentScore += coinValue;
                //Debug.Log(gameMaster);

                Destroy(gameObject);
            }
        }
    }
}