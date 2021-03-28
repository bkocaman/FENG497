using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
	public Transform player;

	private Vector2 pos;
	private Vector2 pos2;
	private int range;

	[Header("Side Walls")]
	public GameObject wallsPrefab;
	public float currentWallY;
	public float wallTall = 11.5f;
	public float distanceBeforeSpawn = 10f;
	public int initialWalls = 3;
	public List<GameObject> wallPool;

	[Header("Platforms")]
	public GameObject blockPrefab; // normal Donut //
	public GameObject blockPrefab_pink; // pink donut //
	public GameObject blockPrefab_movable;  // moving chocolate //
	public float currentBlockY;  // distance between the ground and the current location //
	public float distanceBetweenBlocks = 5f;
	public float distanceBeforeSpawnBlock = 10f;
	public int initBlocksLine = 2;
	public List<GameObject> blocksPool;

	private void Awake()
	{
		InitSideWalls();
		InitBlocks();
	}

	private void Update()
	{
		if (currentWallY - player.position.y < distanceBeforeSpawn)
		{
			SpawnSideWall();
		}

		if (currentBlockY - player.position.y < distanceBeforeSpawnBlock)
		{
			SpawnBlocks();
		}
	}

	private void InitSideWalls()
	{
		for (int i = 0; i < initialWalls; ++i)
		{
			pos = new Vector2(0, currentWallY);
			GameObject go = Instantiate(wallsPrefab, pos, Quaternion.identity, transform);
			wallPool.Add(go);
			currentWallY += wallTall;
		}
	}

	private void InitFirst()
    {
		pos2 = new Vector2(Random.Range(-5, 5), currentBlockY);
		range = Random.Range(0, 100);
		GameObject go = Instantiate(blockPrefab, pos2, Quaternion.identity, transform);
		blocksPool.Add(go);
		currentBlockY += distanceBetweenBlocks;
	}

	private void InitBlocks()
	{
		InitFirst(); // Initialize first block as a static black donut //

		for (int i = 0; i < initBlocksLine; i++)
		{
			pos2 = new Vector2(Random.Range(-5, 5), currentBlockY);
			range = Random.Range(0, 100);

			if (range <= 50) // % 50 normal  donat//
			{
				GameObject go = Instantiate(blockPrefab, pos2, Quaternion.identity, transform);
				blocksPool.Add(go);
				currentBlockY += distanceBetweenBlocks;
			}
			else if (range > 50 && range < 90) // % 40 pink donat //
			{
				GameObject go = Instantiate(blockPrefab_pink, pos2, Quaternion.identity, transform);
				blocksPool.Add(go);
				currentBlockY += distanceBetweenBlocks;
			}
			else
			{
				pos2 = new Vector2(-5, currentBlockY);
				GameObject go = Instantiate(blockPrefab_movable, pos2, Quaternion.identity, transform);
				blocksPool.Add(go);
				currentBlockY += distanceBetweenBlocks;
			}
		}
	}

	private void SpawnSideWall()
	{
		wallPool[0].transform.position = new Vector2(0, currentWallY);
		currentWallY += wallTall;
		GameObject temp = wallPool[0];
		wallPool.RemoveAt(0);
		wallPool.Add(temp);
	}

	private void SpawnBlocks()
	{
		pos2 = new Vector2(Random.Range(-5, 5), currentBlockY);
		range = Random.Range(0, 100);

		if (range <= 50) // % 50 normal  donat//
		{
			GameObject go = Instantiate(blockPrefab, pos2, Quaternion.identity, transform);
			blocksPool.Add(go);
			currentBlockY += distanceBetweenBlocks;
		}
		else if (range > 50 && range < 90) // % 40 pink donat //
		{
			GameObject go = Instantiate(blockPrefab_pink, pos2, Quaternion.identity, transform);
			blocksPool.Add(go);
			currentBlockY += distanceBetweenBlocks;
		}
		else
		{
			pos2 = new Vector2(-5, currentBlockY);
			GameObject go = Instantiate(blockPrefab_movable, pos2, Quaternion.identity, transform);
			blocksPool.Add(go);
			currentBlockY += distanceBetweenBlocks;
		}
		Destroy(blocksPool[0]);
		blocksPool.RemoveAt(0);
	}
}
