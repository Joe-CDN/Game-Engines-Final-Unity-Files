using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawn : MonoBehaviour
{
    public Transform cubePrefab;

    [SerializeField]
    private float delay = 1f;

    private float lastTime;

    // Update is called once per frame
    void Update()
    {
        if(Time.time - lastTime > delay){
            lastTime = Time.time;
            ICommand command = new SpawnCubeCommand(this.transform.position, cubePrefab);
            CommandInvoker.AddCopmmand(command);            
        }
    }
}
