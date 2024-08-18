using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WoodPuzzle.Core
{
    public class Level : MonoBehaviour, IGameFlow
    {
        private int numOfEnemey = 0;

        private void Awake()
        {
            var enemies = GameObject.FindObjectsOfType<Enemy>();

            numOfEnemey = enemies.Length;

            foreach (Enemy enemy in enemies)
            {
                enemy.SetLevel(this);
            }
        }

        public void AEnemyBeKilled()
        {
            numOfEnemey--;

            if (numOfEnemey <= 0)
            {
                OnFinishGame(EndGameType.WIN);
            }
        }

        public void OnFinishGame(EndGameType type)
        {
            GameManager.Instance.FinishGame(type);
        }

        public void OnPauseGame()
        {
            
        }

        public void OnPrepareGame()
        {
            
        }

        public void OnResumeGame()
        {
            
        }

        public void OnStartGame()
        {
            
        }
    }
}


