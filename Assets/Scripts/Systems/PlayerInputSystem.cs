﻿using Unity.Entities;
using Unity.Jobs;
using UnityEngine;

[AlwaysSynchronizeSystem]

public class PlayerInputSystem : JobComponentSystem
{
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        Entities.ForEach((ref PaddleMovimentData moveData, in PaddleInputData inputData ) =>
        {
            moveData.diretion = 0;

            moveData.diretion += Input.GetKey(inputData.upKey) ? 1 : 0;
            moveData.diretion -= Input.GetKey(inputData.downKey) ? 1 : 0;

        }).Run();

        return default;
    }
}
