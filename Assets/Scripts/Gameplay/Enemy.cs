using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WoodPuzzle.Core;

public class Enemy : MonoBehaviour
{
    private Level level;

    public void SetLevel(Level level)
    {
        this.level = level;
    }

    private void Update()
    {
        ProcessUserClicking();
    }

    void ProcessUserClicking()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject == this.gameObject)
                {
                    level.AEnemyBeKilled();
                    this.gameObject.SetActive(false);
                }
            }
        }
    }
}
