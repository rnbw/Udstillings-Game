using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingsSpawnerScript : MonoBehaviour
{

    public int numObjects = 100;
    public GameObject prefab;
    public int radius = 100;

    void Start()
    {
        Transform pos = this.transform;

        for (int i = 0; i < numObjects; i++)
        {
            int x = Random.Range(-radius, radius);
            int y = Random.Range(-radius/2, radius/2);
            float random = Random.Range(-0.2f, 0.2f);
            Vector3 newPos = new Vector3(pos.position.x + x + Random.Range(-0.2f, 0.2f), pos.position.y + y * 4 + random, pos.position.y + y * 2 + random);

            Collider2D[] cols = Physics2D.OverlapCircleAll(new Vector2(pos.position.x + x, pos.position.y + y), 5f);
            Collider2D[] cols2 = Physics2D.OverlapCircleAll(new Vector2(pos.position.x + x+2, pos.position.y + y), 1f);
            Collider2D[] cols3 = Physics2D.OverlapCircleAll(new Vector2(pos.position.x + x + 4, pos.position.y + y), 1f);
            Collider2D[] cols4 = Physics2D.OverlapCircleAll(new Vector2(pos.position.x + x + 6, pos.position.y + y), 1f);

            if (cols != null && cols2 != null && cols3 != null && cols4 != null)
            {
                Instantiate(prefab, newPos, Quaternion.identity);
            }
            else { break; }
            
        }
    }   
}
