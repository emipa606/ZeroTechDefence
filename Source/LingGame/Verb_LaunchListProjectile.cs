using Verse;

namespace LingGame;

public class Verb_LaunchListProjectile : Verb_Shoot
{
    private int asdasd;

    public override ThingDef Projectile
    {
        get
        {
            var thingDef = caster.TryGetComp<Comp_LaunchListProjectile>().Props.ProjectileDef[asdasd];
            return thingDef ?? base.Projectile;
        }
    }

    protected override bool TryCastShot()
    {
        asdasd++;
        if (asdasd >= caster.TryGetComp<Comp_LaunchListProjectile>().Props.ProjectileDef.Count)
        {
            asdasd = 0;
        }

        return base.TryCastShot();
    }
}