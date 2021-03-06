using UnityEngine;
using System.Collections;

///
/// !!! Machine generated code !!!
/// !!! DO NOT CHANGE Tabs to Spaces !!!
/// 
[System.Serializable]
public class TowerData
{
  [SerializeField]
  int idx;
  public int Idx { get {return idx; } set { this.idx = value;} }
  
  [SerializeField]
  string towername;
  public string Towername { get {return towername; } set { this.towername = value;} }
  
  [SerializeField]
  TowerType towertype;
  public TowerType TOWERTYPE { get {return towertype; } set { this.towertype = value;} }
  
  [SerializeField]
  TowerGrade towergrade;
  public TowerGrade TOWERGRADE { get {return towergrade; } set { this.towergrade = value;} }
  
  [SerializeField]
  float atk;
  public float Atk { get { return atk; } set { this.atk = value; } }
  
  [SerializeField]
  float atkspeed;
  public float Atkspeed { get {return atkspeed; } set { this.atkspeed = value;} }
  
  [SerializeField]
  float range;
  public float Range { get {return range; } set { this.range = value;} }
  
  [SerializeField]
  float splashrange;
  public float Splashrange { get {return splashrange; } set { this.splashrange = value;} }
  
  [SerializeField]
  bool ispenetrate;
  public bool Ispenetrate { get {return ispenetrate; } set { this.ispenetrate = value;} }
  
  [SerializeField]
  string imagepath;
  public string Imagepath { get {return imagepath; } set { this.imagepath = value;} }
  
  [SerializeField]
  string tmi;
  public string TMI { get {return tmi; } set { this.tmi = value;} }

  [SerializeField]
  Vector2 position;
  public Vector2 Position { get { return position; } set { position = value; } }

    float plusATK;
    public float PlusATK { get { return plusATK; } set { plusATK = value; } }

    public enum TowerType
  {
      Grenadier,
      Laser,
      Acher,
      Bullet,
      Buff
  }

  public enum TowerGrade
  {
      Common,
      Uncommon,
      Rare,
      Epic,
      Unique,
      Legendary
  }
  
    public TowerData GetCopiedTowerData()
    {
        return new TowerData
        {
            idx = this.idx,
            atk = this.atk,
            atkspeed = this.atkspeed,
            imagepath = this.imagepath,
            ispenetrate = this.ispenetrate,
            plusATK = this.plusATK,
            position = this.position,
            range = this.range,
            splashrange = this.splashrange,
            tmi = this.tmi,
            towergrade = this.towergrade,
            towername = this.towername,
            towertype = this.towertype
        };
    }
}