﻿using UnityEngine;

[RequireComponent(typeof(NameRenderer))]
[RequireComponent(typeof(HighlightRenderer))]
[RequireComponent(typeof(MouseListener))]
public class Application : MonoBehaviour
{
    public MQ.Application application;

    // Use this for initialization
    void Start()
    {
        // Load Application Prefab and instantiate it
        GameObject applicationPrefab = Resources.Load("Prefabs/Application") as GameObject;
        GameObject instantiatedConn = Instantiate(applicationPrefab);
        instantiatedConn.transform.parent = gameObject.transform;
        instantiatedConn.transform.localPosition = Vector3.zero;
        instantiatedConn.name = this.name + ".Prefab";
        instantiatedConn.transform.name = instantiatedConn.name;

        // Add mesh Colider
        MeshCollider mc = gameObject.AddComponent<MeshCollider>();
        mc.sharedMesh = instantiatedConn.GetComponent<MeshFilter>().sharedMesh;
    }

}
