using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBulletPool : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab = null;
    [SerializeField] Transform poolParent = null;
    List<BulletScript> bulletPool = new List<BulletScript>();

    public BulletScript GetBullet(Vector2 startPos)
    {
        BulletScript result = bulletPool.Find(x => !x.gameObject.activeSelf);

        if (result == null)
        {
            result = MakeNewBullet(startPos);
        }
        else
        {
            result.transform.position = startPos;
        }

        result.gameObject.SetActive(true);
        return result;
    }

    private BulletScript MakeNewBullet(Vector2 startPos)
    {
        BulletScript result = Instantiate(bulletPrefab, startPos, Quaternion.identity, poolParent).GetComponent<BulletScript>();
        bulletPool.Add(result);
        return result;
    }
}
