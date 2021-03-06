using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TowerMerge : MonoBehaviour
{
    TowerScript tower;

    SpriteRenderer sr = null;
    TowerManager towerManager = null;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        tower = GetComponent<TowerScript>();
    }

    private void OnEnable()
    {
        if (towerManager == null)
        {
            towerManager = GameManager.Instance.towerManager;
        }
    }

    void Start()
    {
        if (towerManager == null)
        {
            towerManager = GameManager.Instance.towerManager;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(tag))
        {
            if (tower.TowerData.TOWERGRADE == TowerData.TowerGrade.Legendary)
            {
                return;
            }

            TowerMerge otherTower = collision.transform.GetComponent<TowerMerge>();
            if (otherTower != null)
            {
                if (otherTower.tower.TowerData.Idx == tower.TowerData.Idx)
                {
                    towerManager.AddMergeReadyTower(this);
                    return;
                }
            }
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag(tag))
        {
            if (tower.TowerData.TOWERGRADE == TowerData.TowerGrade.Legendary)
            {
                return;
            }

            TowerMerge otherTower = collision.transform.GetComponent<TowerMerge>();
            if (otherTower != null)
            {
                if (otherTower.tower.TowerData.Idx == tower.TowerData.Idx)
                {
                    towerManager.AddMergeReadyTower(this);
                    return;
                }
            }
        }
    }

    public TowerData.TowerGrade GetTowerGrade()
    {
        return tower.TowerData.TOWERGRADE;
    }

    public TowerData.TowerType GetTowerType()
    {
        return tower.TowerData.TOWERTYPE;
    }

    public int GetTowerIdx()
    {
        return tower.TowerData.Idx;
    }
}
