using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpwan : MonoBehaviour
{
    public GameObject[] prefabs;

    private BoxCollider2D area;

    public int count = 100;

    private List<GameObject> gameObject = new List<GameObject>();

    // Start is called before the first frame update
    void Awake()
    {
        area = GetComponent<BoxCollider2D>();

        for (int i = 0; i < count; ++i)
        {
            Spawn();
        }
        area.enabled = false;

    }
    public Vector2 GetRandomPosition()
    {
        Vector2 basePosition = transform.position;
        Vector2 size = area.size;

        float posX = basePosition.x + Random.Range(-size.x / 2f, size.x / 2f);
        float posY = basePosition.y + Random.Range(-size.y / 2f, size.y / 2f);

        Vector2 spawnPos = new Vector2(posX, posY);

        return spawnPos;
    }
    private void Spawn()
    {
        int selection = Random.Range(0, prefabs.Length);

        GameObject seletedPrefab = prefabs[selection];

        Vector2 spawnPos = GetRandomPosition();

        GameObject instance = Instantiate(seletedPrefab, spawnPos, Quaternion.identity);
        gameObject.Add(instance);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
