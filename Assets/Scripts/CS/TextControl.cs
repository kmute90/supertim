using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.CS
{
    public class TextControl : MonoBehaviour
    {
        public bool isQuitButton = false;

        public bool isLoadLevelIntroButton = false;

        public bool isLoadLevelButton = false;

        public bool isLoadTutorialButton = false;

        public bool isLoadMenuButton = false;
        
        public void OnMouseUp()
        {
            if (gameObject.guiText != null)
            {
                gameObject.guiText.color = new Color(0, 255, 255);
            }

            if (isLoadLevelIntroButton)
            {
                Application.LoadLevel("levelView");
            }
            else if (isLoadTutorialButton)
            {
                Application.LoadLevel("tutorial");
            }
            else if (isLoadLevelButton)
            {
                Application.LoadLevel("level" + GameMaster.currentLevel);
            }
            else if (isLoadMenuButton)
            {
                Application.LoadLevel("mainMenu");
            }
            else if (isQuitButton)
            {
                Application.Quit();
            }
        }

    }
}
