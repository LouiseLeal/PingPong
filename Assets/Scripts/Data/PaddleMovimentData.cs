using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

[GenerateAuthoringComponent]
public struct PaddleMovimentData : IComponentData
{
    public int diretion;
    public float speed;
}
