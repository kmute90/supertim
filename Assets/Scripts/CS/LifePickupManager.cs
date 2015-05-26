using UnityEngine;
using System.Collections;

namespace Assets.Scripts.CS
{
    public class LifePickupManager : MonoBehaviour
    {
        public int lifeValue = 1;

        public void OnTriggerEnter2D(Collider2D coll)
        {
            if (coll.gameObject.tag == "Player")
            {
                GameMaster.currentLife += lifeValue;
                //Debug.Log(gameMaster);

                Destroy(gameObject);
            }
        }
    }
}