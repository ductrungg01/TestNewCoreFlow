using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WoodPuzzle.Core;

namespace WoodPuzzle.UI
{
    public class PopupInGame : PopupBase
    {
        public TMP_Text levelText;
        public Button ReplayButton;
        public Button PauseButton;
        public Button TestWinButton;
        public Button TestLoseButton;

        private void Start()
        {
            ReplayButton.onClick.AddListener(OnClickBtnReplay);
            PauseButton.onClick.AddListener(OnClickBtnReplay);
            TestWinButton.onClick.AddListener( () => OnClickBtnEndGame(EndGameType.WIN));
            TestLoseButton.onClick.AddListener( () => OnClickBtnEndGame(EndGameType.LOSE));
        }

        protected override void OnShown()
        {
            levelText.text = "Level " + GameBase.CurrentLevel;
        }

        public void OnClickBtnReplay()
        {
            UiManager.Instance.GetPopupHome().OnClickBtnStart();
        }

        public void OnClickBtnPause()
        {

        }

        public void OnClickBtnEndGame(EndGameType type)
        {
            GameManager.Instance.FinishGame(type);
        }
    }
}


