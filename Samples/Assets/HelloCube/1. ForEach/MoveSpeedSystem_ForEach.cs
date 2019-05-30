using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

// This system updates all entities in the scene with both a RotationSpeed_ForEach and Rotation component.

// ReSharper disable once InconsistentNaming
public class MoveSpeedSystem_ForEach : ComponentSystem
{
    protected override void OnUpdate()
    {
        // Entities.ForEach processes each set of ComponentData on the main thread. This is not the recommended
        // method for best performance. However, we start with it here to demonstrate the clearer separation
        // between ComponentSystem Update (logic) and ComponentData (data).
        // There is no update logic on the individual ComponentData.
        Entities.ForEach((ref MoveSpeed_ForEach moveSpeed, ref Translation translation) =>
        {
            var deltaTime = Time.deltaTime;
            // 让他来回跑
            if (translation.Value.x >= 5 || translation.Value.x <= -5)
            {
                moveSpeed.MovePerSecond *= -1;
            }
            translation.Value = translation.Value + moveSpeed.MovePerSecond * deltaTime;
        });
    }
}
