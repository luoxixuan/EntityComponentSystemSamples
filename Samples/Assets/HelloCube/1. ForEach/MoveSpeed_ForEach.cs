using System;
using Unity.Entities;
using Unity.Mathematics;

// Serializable attribute is for editor support.
// ReSharper disable once InconsistentNaming
[Serializable]
public struct MoveSpeed_ForEach : IComponentData
{
    public float3 MovePerSecond;
}
