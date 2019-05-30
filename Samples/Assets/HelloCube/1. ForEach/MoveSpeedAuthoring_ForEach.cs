using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

// ReSharper disable once InconsistentNaming
[RequiresEntityConversion]
public class MoveSpeedAuthoring_ForEach : MonoBehaviour, IConvertGameObjectToEntity
{
    public float MoveXPerSecond;

    // The MonoBehaviour data is converted to ComponentData on the entity.
    // We are specifically transforming from a good editor representation of the data (Represented in degrees)
    // To a good runtime representation (Represented in radians)
    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        var data = new MoveSpeed_ForEach { MovePerSecond = new float3(MoveXPerSecond,0,0) };
        dstManager.AddComponentData(entity, data);
    }
}
