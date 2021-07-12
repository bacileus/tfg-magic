using System.Collections;
using System.Collections.Generic;
using Antlr4.Runtime.Misc;
using UnityEngine;

public class SpellCreator : SpellCreatorBaseListener
{
    private static Dictionary<string, string> frag2token = new Dictionary<string, string>()
    {
        { "PITTY", "SMALL" },
        { "TINY", "SMALL" },
        { "SPARKING", "SMALL" },
        { "WALKING", "SMALL" },
        { "COMMON", "MEDIUM" },
        { "LARGE", "MEDIUM" },
        { "ENDURING", "MEDIUM" },
        { "RUNNING", "MEDIUM" },
        { "GREAT", "LARGE" },
        { "MAJESTIC", "LARGE" },
        { "EVERLASTING", "LARGE" },
        { "FLYING", "LARGE" }
    };
    private static Dictionary<string, Dictionary<string, int> > token2value = new Dictionary<string, Dictionary<string, int>>() {
        { "SMALL", new Dictionary<string, int> {
            { "LIFEMAGNITUDE", 10 },
            { "LIFEDURATION", 1 },
            { "RESISTANCEMAGNITUDE", 25 },
            { "RESISTANCEDURATION", 1 },
            { "SPEEDMAGNITUDE", 25 },
            { "SPEEDDURATION", 1 },
            { "PROJECTILESIZE", 1},
            { "AREASIZE", 3},
            { "IMPULSESPEED", 10},
            { "CHASESPEED", 5},
            { "FALLSPEED", 10},
            { "DESTROYTIME", 1},
            { "RICOCHETBOUNCES", 2},
            { "MULTIPLEWAVES", 1}
        }},
        { "MEDIUM", new Dictionary<string, int> {
            { "LIFEMAGNITUDE", 20 },
            { "LIFEDURATION", 5 },
            { "RESISTANCEMAGNITUDE", 50 },
            { "RESISTANCEDURATION", 5 },
            { "SPEEDMAGNITUDE", 50 },
            { "SPEEDDURATION", 5 },
            { "PROJECTILESIZE", 2},
            { "AREASIZE", 5},
            { "IMPULSESPEED", 15},
            { "CHASESPEED", 10},
            { "FALLSPEED", 20},
            { "DESTROYTIME", 3},
            { "RICOCHETBOUNCES", 4},
            { "MULTIPLEWAVES", 2}
        }},
        { "LARGE", new Dictionary<string, int> {
            { "LIFEMAGNITUDE", 30 },
            { "LIFEDURATION", 10 },
            { "RESISTANCEMAGNITUDE", 100 },
            { "RESISTANCEDURATION", 10 },
            { "SPEEDMAGNITUDE", 75 },
            { "SPEEDDURATION", 10 },
            { "PROJECTILESIZE", 3},
            { "AREASIZE", 7},
            { "IMPULSESPEED", 20},
            { "CHASESPEED", 15},
            { "FALLSPEED", 30},
            { "DESTROYTIME", 5},
            { "RICOCHETBOUNCES", 6},
            { "MULTIPLEWAVES", 3}
        }}
    };
    private Spell spell;
    private ElementDef element;
    private Shape shape;
    private Effect effect;
    private Demeanour demeanour;
    private Impact impact;

    // CONSTRUCTOR
    public SpellCreator() { }

    // GETTER
    public Spell getSpell()
    {
        return spell;
    }

    // CREATE SPELL
    public override void ExitSpell([NotNull] SpellCreatorParser.SpellContext context)
    {       
        spell = new Spell(element, shape, effect, demeanour, impact);
    }

    // ELEMENTS
    public override void ExitFire([NotNull] SpellCreatorParser.FireContext context)
    {
        element = Resources.Load<ElementDef>("Elements/Fire");
    }

    public override void ExitIce([NotNull] SpellCreatorParser.IceContext context)
    {
        element = Resources.Load<ElementDef>("Elements/Ice");
    }

    public override void ExitShock([NotNull] SpellCreatorParser.ShockContext context)
    {
        element = Resources.Load<ElementDef>("Elements/Shock");
    }

    // EFFECTS
    public override void ExitLife([NotNull] SpellCreatorParser.LifeContext context)
    {        
        string magnitudeFrag;
        string durationFrag;

        bool isWise = context.WISE() != null;
        setLifeFrags(isWise, context, out magnitudeFrag, out durationFrag);
             
        string magnitudeToken = frag2token[magnitudeFrag];
        string durationToken = frag2token[durationFrag];
        int magnitude = token2value[magnitudeToken]["LIFEMAGNITUDE"];
        int duration = token2value[durationToken]["LIFEDURATION"];

        if(context.SIGN().GetText() == "DEBUFF") magnitude *= -1;

        EffectDef effectDef = Resources.Load<EffectDef>("Effects/Life");

        effect = new Life(magnitude, duration, isWise, effectDef);
    }

    public override void ExitResistance([NotNull] SpellCreatorParser.ResistanceContext context)
    {        
        string magnitudeFrag;
        string durationFrag;

        bool isWise = context.WISE() != null;
        setResistanceFrags(isWise, context, out magnitudeFrag, out durationFrag);

        string magnitudeToken = frag2token[magnitudeFrag];
        string durationToken = frag2token[durationFrag];
        int magnitude = token2value[magnitudeToken]["RESISTANCEMAGNITUDE"];
        int duration = token2value[durationToken]["RESISTANCEDURATION"];

        if(context.SIGN().GetText() == "DEBUFF") magnitude *= -1;

        EffectDef effectDef = Resources.Load<EffectDef>("Effects/Resistance");

        effect = new Resistance(magnitude, duration, isWise, effectDef);
    }

    public override void ExitSpeed([NotNull] SpellCreatorParser.SpeedContext context)
    {
        string magnitudeFrag;
        string durationFrag;

        bool isWise = context.WISE() != null;
        setSpeedFrags(isWise, context, out magnitudeFrag, out durationFrag);

        string magnitudeToken = frag2token[magnitudeFrag];
        string durationToken = frag2token[durationFrag];
        int magnitude = token2value[magnitudeToken]["SPEEDMAGNITUDE"];
        int duration = token2value[durationToken]["SPEEDDURATION"];

        if(context.SIGN().GetText() == "DEBUFF") magnitude *= -1;

        EffectDef effectDef = Resources.Load<EffectDef>("Effects/Speed");

        effect = new Speed(magnitude, duration, isWise, effectDef);
    }

    // SHAPES
    public override void ExitProjectile([NotNull] SpellCreatorParser.ProjectileContext context)
    {
        string radiusFrag;
        if(context.ADJECTIVE() != null) radiusFrag = context.ADJECTIVE().GetText();
        else radiusFrag = "LARGE";
        string radiusToken = frag2token[radiusFrag];
        int radius = token2value[radiusToken]["PROJECTILESIZE"];

        shape = new Projectile(radius);

        if(demeanour == null) {
            string speedFrag = "RUNNING";
            string speedToken = frag2token[speedFrag];
            int speed = token2value[speedToken]["IMPULSESPEED"];
            demeanour = new Impulse(speed);
        }
        if(impact == null) {
            string timeFrag = "SPARKING";
            string timeToken = frag2token[timeFrag];
            int time = token2value[timeToken]["DESTROYTIME"];
            impact = new Destroy(time);
        }
    }

    public override void ExitArea([NotNull] SpellCreatorParser.AreaContext context)
    {
        string radiusFrag;
        if(context.ADJECTIVE() != null) radiusFrag = context.ADJECTIVE().GetText();
        else radiusFrag = "LARGE";
        string radiusToken = frag2token[radiusFrag];
        int radius = token2value[radiusToken]["AREASIZE"];

        shape = new Area(radius);

        if(demeanour == null) {
            demeanour = new Instant();
        }
        if(impact == null) {
            string timeFrag = "ENDURING";
            string timeToken = frag2token[timeFrag];
            int time = token2value[timeToken]["DESTROYTIME"];
            impact = new Destroy(time);
        }
    }

    public override void ExitSelf([NotNull] SpellCreatorParser.SelfContext context)
    {
        shape = new Self();

        if(demeanour == null) {
            demeanour = new Child();
        }
        if(impact == null) {
            string timeFrag = "ENDURING";
            string timeToken = frag2token[timeFrag];
            int time = token2value[timeToken]["DESTROYTIME"];
            impact = new Destroy(time);
        }
    }

    // DEMEANOURS
    public override void ExitInstant([NotNull] SpellCreatorParser.InstantContext context)
    {
        demeanour = new Instant();
    }

    public override void ExitImpulse([NotNull] SpellCreatorParser.ImpulseContext context)
    {
        string speedFrag;
        if(context.ADJECTIVE() != null) speedFrag = context.ADJECTIVE().GetText();
        else speedFrag = "RUNNING";
        string speedToken = frag2token[speedFrag];
        int speed = token2value[speedToken]["IMPULSESPEED"];

        demeanour = new Impulse(speed);
    }

    public override void ExitChase([NotNull] SpellCreatorParser.ChaseContext context)
    {
        string speedFrag;
        if(context.ADJECTIVE() != null) speedFrag = context.ADJECTIVE().GetText();
        else speedFrag = "RUNNING";
        string speedToken = frag2token[speedFrag];
        int speed = token2value[speedToken]["CHASESPEED"];

        demeanour = new Chase(speed);
    }

    public override void ExitFall([NotNull] SpellCreatorParser.FallContext context)
    {
        string speedFrag;
        if(context.ADJECTIVE() != null) speedFrag = context.ADJECTIVE().GetText();
        else speedFrag = "RUNNING";
        string speedToken = frag2token[speedFrag];
        int speed = token2value[speedToken]["FALLSPEED"];

        demeanour = new Fall(speed);
    }

    public override void ExitParent([NotNull] SpellCreatorParser.ParentContext context)
    {
        demeanour = new Child();
    }

    // IMPACTS
    public override void ExitDestroy([NotNull] SpellCreatorParser.DestroyContext context)
    {
        string timeFrag;
        if(context.ADJECTIVE() != null) timeFrag = context.ADJECTIVE().GetText();
        else timeFrag = "ENDURING";
        string timeToken = frag2token[timeFrag];
        int time = token2value[timeToken]["DESTROYTIME"];

        impact = new Destroy(time);
    }

    public override void ExitRicochet([NotNull] SpellCreatorParser.RicochetContext context)
    {
        string bouncesFrag;
        if(context.ADJECTIVE() != null) bouncesFrag = context.ADJECTIVE().GetText();
        else bouncesFrag = "ENDURING";
        string bouncesToken = frag2token[bouncesFrag];
        int bounces = token2value[bouncesToken]["RICOCHETBOUNCES"];

        impact = new Ricochet(bounces);
    }

    public override void ExitMultiple([NotNull] SpellCreatorParser.MultipleContext context)
    {
        string wavesFrag;
        if(context.ADJECTIVE() != null) wavesFrag = context.ADJECTIVE().GetText();
        else wavesFrag = "ENDURING";
        string wavesToken = frag2token[wavesFrag];
        int waves = token2value[wavesToken]["MULTIPLEWAVES"];

        impact = new Multiple(waves);
    }

    // DEFAULT EFFECT METHODS
    private void setLifeFrags(bool isWise, [NotNull] SpellCreatorParser.LifeContext context, out string magnitudeFrag, out string durationFrag) {
        int count = context.ChildCount;
        switch (count) {
            case 3:
                if(isWise) goto default;
                else {
                    string token = context.ADJECTIVE()[0].GetText();
                    bool isMagnitude = (token == "PITTY") || (token == "COMMON") || (token == "GREAT");
                    if(isMagnitude) {
                        magnitudeFrag = token;
                        durationFrag = "ENDURING";
                    } else {
                        magnitudeFrag = "COMMON";
                        durationFrag = token;
                    }
                }
                break;
            case 4:
                if(!isWise) goto case 5;
                else {
                    string token = context.ADJECTIVE()[0].GetText();
                    bool isMagnitude = (token == "PITTY") || (token == "COMMON") || (token == "GREAT");
                    if(isMagnitude) {
                        magnitudeFrag = token;
                        durationFrag = "ENDURING";
                    } else {
                        magnitudeFrag = "COMMON";
                        durationFrag = token;
                    }
                }
                break;
            case 5:
                magnitudeFrag = context.ADJECTIVE()[0].GetText();
                durationFrag = context.ADJECTIVE()[1].GetText();
                break;
            default:
                magnitudeFrag = "COMMON";
                durationFrag = "ENDURING";
                break;
        }
    }

    private void setResistanceFrags(bool isWise, [NotNull] SpellCreatorParser.ResistanceContext context, out string magnitudeFrag, out string durationFrag) {
        int count = context.ChildCount;
        switch (count) {
            case 3:
                if(isWise) goto default;
                else {
                    string token = context.ADJECTIVE()[0].GetText();
                    bool isMagnitude = (token == "PITTY") || (token == "COMMON") || (token == "GREAT");
                    if(isMagnitude) {
                        magnitudeFrag = token;
                        durationFrag = "ENDURING";
                    } else {
                        magnitudeFrag = "COMMON";
                        durationFrag = token;
                    }
                }
                break;
            case 4:
                if(!isWise) goto case 5;
                else {
                    string token = context.ADJECTIVE()[0].GetText();
                    bool isMagnitude = (token == "PITTY") || (token == "COMMON") || (token == "GREAT");
                    if(isMagnitude) {
                        magnitudeFrag = token;
                        durationFrag = "ENDURING";
                    } else {
                        magnitudeFrag = "COMMON";
                        durationFrag = token;
                    }
                }
                break;
            case 5:
                magnitudeFrag = context.ADJECTIVE()[0].GetText();
                durationFrag = context.ADJECTIVE()[1].GetText();
                break;
            default:
                magnitudeFrag = "COMMON";
                durationFrag = "ENDURING";
                break;
        }
    }

    private void setSpeedFrags(bool isWise, [NotNull] SpellCreatorParser.SpeedContext context, out string magnitudeFrag, out string durationFrag) {
        int count = context.ChildCount;
        switch (count) {
            case 3:
                if(isWise) goto default;
                else {
                    string token = context.ADJECTIVE()[0].GetText();
                    bool isMagnitude = (token == "PITTY") || (token == "COMMON") || (token == "GREAT");
                    if(isMagnitude) {
                        magnitudeFrag = token;
                        durationFrag = "ENDURING";
                    } else {
                        magnitudeFrag = "COMMON";
                        durationFrag = token;
                    }
                }
                break;
            case 4:
                if(!isWise) goto case 5;
                else {
                    string token = context.ADJECTIVE()[0].GetText();
                    bool isMagnitude = (token == "PITTY") || (token == "COMMON") || (token == "GREAT");
                    if(isMagnitude) {
                        magnitudeFrag = token;
                        durationFrag = "ENDURING";
                    } else {
                        magnitudeFrag = "COMMON";
                        durationFrag = token;
                    }
                }
                break;
            case 5:
                magnitudeFrag = context.ADJECTIVE()[0].GetText();
                durationFrag = context.ADJECTIVE()[1].GetText();
                break;
            default:
                magnitudeFrag = "COMMON";
                durationFrag = "ENDURING";
                break;
        }
    }
}
