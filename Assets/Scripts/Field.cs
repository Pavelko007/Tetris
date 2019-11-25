using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    public GameObject BlockPrefab;

    // Start is called before the first frame update
    void Start()
    {
        SpawnBlockText();
    }

    private void SpawnBlockText()
    {
        Instantiate(BlockPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        var colorBefore = Gizmos.color;
        Gizmos.color = Color.blue;

        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                var startPos = Vector2.zero + Vector2.down*i + Vector2.right*j;

                Gizmos.DrawWireCube(startPos, Vector3.one);
            }
        }
        

        Gizmos.color = colorBefore;
    }


}
