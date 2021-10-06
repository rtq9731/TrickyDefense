using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelWiki : MonoBehaviour
{
    [SerializeField] PanelInfo panelInfo = null;
    [SerializeField] GameObject wikiIconPrefab;
    [SerializeField] Toggle toggleAllTower;
    [SerializeField] Toggle toggleGrenadierTower;
    [SerializeField] Toggle toggleLaserTower;
    [SerializeField] Toggle toggleAcherTower;
    [SerializeField] Toggle toggleBulletTower;
    [SerializeField] Toggle toggleBuffTower;

    List<TowerData> towerDatas = new List<TowerData>();
    List<TowerWikiIconElement> icons = new List<TowerWikiIconElement>();

    private void Start()
    {
        towerDatas = GameManager.Instance.tower.GetTowerDatas();
        for (int i = 0; i < towerDatas.Count; i++)
        {
            TowerWikiIconElement tmp = Instantiate(wikiIconPrefab).GetComponent<TowerWikiIconElement>();
            tmp.Init(towerDatas[i]);
            icons.Add(tmp);
        }

        toggleAllTower.onValueChanged.AddListener(isOn =>
        {
            if(isOn)
            {
                icons.ForEach(x => x.gameObject.SetActive(isOn));
            }
        });

        toggleGrenadierTower.onValueChanged.AddListener(isOn =>
        {
            if (isOn)
            {
                icons.FindAll(x => x.data.TOWERTYPE == TowerData.TowerType.Grenadier).ForEach(x => x.gameObject.SetActive(true));
            }
        });

        toggleLaserTower.onValueChanged.AddListener(isOn =>
        {
            if (isOn)
            {
                icons.FindAll(x => x.data.TOWERTYPE == TowerData.TowerType.Laser).ForEach(x => x.gameObject.SetActive(true));
            }
        });

        toggleAcherTower.onValueChanged.AddListener(isOn =>
        {
            if (isOn)
            {
                icons.FindAll(x => x.data.TOWERTYPE == TowerData.TowerType.Acher).ForEach(x => x.gameObject.SetActive(true));
            }
        });

        toggleBulletTower.onValueChanged.AddListener(isOn =>
        {
            if (isOn)
            {
                icons.FindAll(x => x.data.TOWERTYPE == TowerData.TowerType.Bullet).ForEach(x => x.gameObject.SetActive(true));
            }
        });

        toggleBuffTower.onValueChanged.AddListener(isOn =>
        {
            if (isOn)
            {
                icons.FindAll(x => x.data.TOWERTYPE == TowerData.TowerType.Buff).ForEach(x => x.gameObject.SetActive(true));
            }
        });
    }

    

}