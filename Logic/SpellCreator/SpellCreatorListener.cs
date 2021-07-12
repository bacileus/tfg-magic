//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from .\SpellCreator.g4 by ANTLR 4.9.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="SpellCreatorParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.1")]
[System.CLSCompliant(false)]
public interface ISpellCreatorListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpellCreatorParser.spell"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSpell([NotNull] SpellCreatorParser.SpellContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpellCreatorParser.spell"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSpell([NotNull] SpellCreatorParser.SpellContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpellCreatorParser.element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElement([NotNull] SpellCreatorParser.ElementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpellCreatorParser.element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElement([NotNull] SpellCreatorParser.ElementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpellCreatorParser.fire"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFire([NotNull] SpellCreatorParser.FireContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpellCreatorParser.fire"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFire([NotNull] SpellCreatorParser.FireContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpellCreatorParser.ice"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIce([NotNull] SpellCreatorParser.IceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpellCreatorParser.ice"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIce([NotNull] SpellCreatorParser.IceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpellCreatorParser.shock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShock([NotNull] SpellCreatorParser.ShockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpellCreatorParser.shock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShock([NotNull] SpellCreatorParser.ShockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpellCreatorParser.effect"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEffect([NotNull] SpellCreatorParser.EffectContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpellCreatorParser.effect"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEffect([NotNull] SpellCreatorParser.EffectContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpellCreatorParser.life"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLife([NotNull] SpellCreatorParser.LifeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpellCreatorParser.life"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLife([NotNull] SpellCreatorParser.LifeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpellCreatorParser.resistance"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterResistance([NotNull] SpellCreatorParser.ResistanceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpellCreatorParser.resistance"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitResistance([NotNull] SpellCreatorParser.ResistanceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpellCreatorParser.speed"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSpeed([NotNull] SpellCreatorParser.SpeedContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpellCreatorParser.speed"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSpeed([NotNull] SpellCreatorParser.SpeedContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpellCreatorParser.shape"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShape([NotNull] SpellCreatorParser.ShapeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpellCreatorParser.shape"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShape([NotNull] SpellCreatorParser.ShapeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpellCreatorParser.projectile"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProjectile([NotNull] SpellCreatorParser.ProjectileContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpellCreatorParser.projectile"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProjectile([NotNull] SpellCreatorParser.ProjectileContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpellCreatorParser.area"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArea([NotNull] SpellCreatorParser.AreaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpellCreatorParser.area"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArea([NotNull] SpellCreatorParser.AreaContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpellCreatorParser.self"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelf([NotNull] SpellCreatorParser.SelfContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpellCreatorParser.self"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelf([NotNull] SpellCreatorParser.SelfContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpellCreatorParser.demeanour"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDemeanour([NotNull] SpellCreatorParser.DemeanourContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpellCreatorParser.demeanour"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDemeanour([NotNull] SpellCreatorParser.DemeanourContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpellCreatorParser.instant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstant([NotNull] SpellCreatorParser.InstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpellCreatorParser.instant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstant([NotNull] SpellCreatorParser.InstantContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpellCreatorParser.impulse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImpulse([NotNull] SpellCreatorParser.ImpulseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpellCreatorParser.impulse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImpulse([NotNull] SpellCreatorParser.ImpulseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpellCreatorParser.chase"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChase([NotNull] SpellCreatorParser.ChaseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpellCreatorParser.chase"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChase([NotNull] SpellCreatorParser.ChaseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpellCreatorParser.fall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFall([NotNull] SpellCreatorParser.FallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpellCreatorParser.fall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFall([NotNull] SpellCreatorParser.FallContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpellCreatorParser.parent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParent([NotNull] SpellCreatorParser.ParentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpellCreatorParser.parent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParent([NotNull] SpellCreatorParser.ParentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpellCreatorParser.impact"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImpact([NotNull] SpellCreatorParser.ImpactContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpellCreatorParser.impact"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImpact([NotNull] SpellCreatorParser.ImpactContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpellCreatorParser.destroy"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDestroy([NotNull] SpellCreatorParser.DestroyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpellCreatorParser.destroy"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDestroy([NotNull] SpellCreatorParser.DestroyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpellCreatorParser.ricochet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRicochet([NotNull] SpellCreatorParser.RicochetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpellCreatorParser.ricochet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRicochet([NotNull] SpellCreatorParser.RicochetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpellCreatorParser.multiple"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiple([NotNull] SpellCreatorParser.MultipleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpellCreatorParser.multiple"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiple([NotNull] SpellCreatorParser.MultipleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpellCreatorParser.connector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConnector([NotNull] SpellCreatorParser.ConnectorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpellCreatorParser.connector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConnector([NotNull] SpellCreatorParser.ConnectorContext context);
}