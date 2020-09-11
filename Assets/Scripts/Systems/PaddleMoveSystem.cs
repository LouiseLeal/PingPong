
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;

[AlwaysSynchronizeSystem]

public class PaddlerMoveSystem : JobComponentSystem
{
    protected override JobHandle OnUpdate(JobHandle inputDependencies)
    {
        float deltaTime = Time.DeltaTime;
        float yBound = GameManager.instance.yBound;

        Entities.ForEach((ref Translation trans, in PaddleMovimentData data) => 
        {
            trans.Value.y = math.clamp(trans.Value.y + (data.speed * data.diretion * deltaTime), -yBound, yBound);
        }).Run();

        return default;
    }
}