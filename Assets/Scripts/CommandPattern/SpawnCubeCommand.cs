using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubeCommand : ICommand
{
    Vector3 position;
    Transform cube;
    public SpawnCubeCommand(Vector3 position, Transform cube)
    {
        this.position = position;
        this.cube = cube;
    }
    
    public void Execute()
    {
        CubePlacer.PlaceCube(position, cube);
    }

    public void Undo()
    {
        CubePlacer.RemoveCube(position);
    }
}
