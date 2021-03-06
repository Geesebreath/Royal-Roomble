﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
	// Set GameObject to Pool in inspector (ie dirtPrefab in this case).
	public static ObjectPool instance;
	public List<GameObject> dirtPool;
	public int poolAmount;
	public GameObject dirtPrefab;
	// Start is called before the first frame update
	private void Awake()
	{
		if(instance !=null)
		{
			Destroy(this);
		}
		instance = this;
	}
	void Start()
	{
		dirtPool = new List<GameObject>();
		for (int i = 0; i < poolAmount; i++)
		{
			GameObject dObj = Instantiate(dirtPrefab);
			dObj.SetActive(false);
			dirtPool.Add(dObj);
		}
	}

	public GameObject GetDirt()
	{
		GameObject o = null;
		//1
		for (int i = 0; i < dirtPool.Count; i++)
		{
			//2
			if (!dirtPool[i].activeInHierarchy)
			{
				o = dirtPool[i];
				i = dirtPool.Count + 1;
			}
		}
		//3   
		return o;
	}

}
