//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.2.2-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\work\SurroundWeb\private\AROS\GestureRecognizerKinectV2\\Z3Experiments\Z3Experiments\Parser\PreposeGestures.g4 by ANTLR 4.2.2-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace PreposeGestures {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="PreposeGesturesParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.2.2-SNAPSHOT")]
[System.CLSCompliant(false)]
public interface IPreposeGesturesListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.thumbs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThumbs([NotNull] PreposeGesturesParser.ThumbsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.thumbs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThumbs([NotNull] PreposeGesturesParser.ThumbsContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.put_restriction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPut_restriction([NotNull] PreposeGesturesParser.Put_restrictionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.put_restriction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPut_restriction([NotNull] PreposeGesturesParser.Put_restrictionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.align_restriction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlign_restriction([NotNull] PreposeGesturesParser.Align_restrictionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.align_restriction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlign_restriction([NotNull] PreposeGesturesParser.Align_restrictionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.direction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDirection([NotNull] PreposeGesturesParser.DirectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.direction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDirection([NotNull] PreposeGesturesParser.DirectionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.hold_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHold_constraint([NotNull] PreposeGesturesParser.Hold_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.hold_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHold_constraint([NotNull] PreposeGesturesParser.Hold_constraintContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.wrists"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWrists([NotNull] PreposeGesturesParser.WristsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.wrists"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWrists([NotNull] PreposeGesturesParser.WristsContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.repeat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRepeat([NotNull] PreposeGesturesParser.RepeatContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.repeat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRepeat([NotNull] PreposeGesturesParser.RepeatContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.execution"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExecution([NotNull] PreposeGesturesParser.ExecutionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.execution"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExecution([NotNull] PreposeGesturesParser.ExecutionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.body_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBody_part([NotNull] PreposeGesturesParser.Body_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.body_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBody_part([NotNull] PreposeGesturesParser.Body_partContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.transform"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTransform([NotNull] PreposeGesturesParser.TransformContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.transform"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTransform([NotNull] PreposeGesturesParser.TransformContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.pose"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPose([NotNull] PreposeGesturesParser.PoseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.pose"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPose([NotNull] PreposeGesturesParser.PoseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.center_joint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCenter_joint([NotNull] PreposeGesturesParser.Center_jointContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.center_joint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCenter_joint([NotNull] PreposeGesturesParser.Center_jointContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.side"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSide([NotNull] PreposeGesturesParser.SideContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.side"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSide([NotNull] PreposeGesturesParser.SideContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.rotate_plane_transform"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRotate_plane_transform([NotNull] PreposeGesturesParser.Rotate_plane_transformContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.rotate_plane_transform"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRotate_plane_transform([NotNull] PreposeGesturesParser.Rotate_plane_transformContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.hands"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHands([NotNull] PreposeGesturesParser.HandsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.hands"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHands([NotNull] PreposeGesturesParser.HandsContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.motion_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMotion_constraint([NotNull] PreposeGesturesParser.Motion_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.motion_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMotion_constraint([NotNull] PreposeGesturesParser.Motion_constraintContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.elbows"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElbows([NotNull] PreposeGesturesParser.ElbowsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.elbows"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElbows([NotNull] PreposeGesturesParser.ElbowsContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.knees"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKnees([NotNull] PreposeGesturesParser.KneesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.knees"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKnees([NotNull] PreposeGesturesParser.KneesContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.arms"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArms([NotNull] PreposeGesturesParser.ArmsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.arms"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArms([NotNull] PreposeGesturesParser.ArmsContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.arm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArm([NotNull] PreposeGesturesParser.ArmContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.arm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArm([NotNull] PreposeGesturesParser.ArmContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.hands_tips"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHands_tips([NotNull] PreposeGesturesParser.Hands_tipsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.hands_tips"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHands_tips([NotNull] PreposeGesturesParser.Hands_tipsContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.relative_direction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelative_direction([NotNull] PreposeGesturesParser.Relative_directionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.relative_direction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelative_direction([NotNull] PreposeGesturesParser.Relative_directionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.joint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoint([NotNull] PreposeGesturesParser.JointContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.joint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoint([NotNull] PreposeGesturesParser.JointContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.app"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterApp([NotNull] PreposeGesturesParser.AppContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.app"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitApp([NotNull] PreposeGesturesParser.AppContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.spine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSpine([NotNull] PreposeGesturesParser.SpineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.spine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSpine([NotNull] PreposeGesturesParser.SpineContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.restriction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRestriction([NotNull] PreposeGesturesParser.RestrictionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.restriction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRestriction([NotNull] PreposeGesturesParser.RestrictionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.gesture"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGesture([NotNull] PreposeGesturesParser.GestureContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.gesture"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGesture([NotNull] PreposeGesturesParser.GestureContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.feet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFeet([NotNull] PreposeGesturesParser.FeetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.feet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFeet([NotNull] PreposeGesturesParser.FeetContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.back"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBack([NotNull] PreposeGesturesParser.BackContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.back"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBack([NotNull] PreposeGesturesParser.BackContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.execution_step"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExecution_step([NotNull] PreposeGesturesParser.Execution_stepContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.execution_step"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExecution_step([NotNull] PreposeGesturesParser.Execution_stepContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.you"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterYou([NotNull] PreposeGesturesParser.YouContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.you"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitYou([NotNull] PreposeGesturesParser.YouContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.rotate_direction_transform"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRotate_direction_transform([NotNull] PreposeGesturesParser.Rotate_direction_transformContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.rotate_direction_transform"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRotate_direction_transform([NotNull] PreposeGesturesParser.Rotate_direction_transformContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.hips"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHips([NotNull] PreposeGesturesParser.HipsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.hips"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHips([NotNull] PreposeGesturesParser.HipsContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.shoulders"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShoulders([NotNull] PreposeGesturesParser.ShouldersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.shoulders"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShoulders([NotNull] PreposeGesturesParser.ShouldersContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.point_to_transform"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPoint_to_transform([NotNull] PreposeGesturesParser.Point_to_transformContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.point_to_transform"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPoint_to_transform([NotNull] PreposeGesturesParser.Point_to_transformContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] PreposeGesturesParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] PreposeGesturesParser.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.leg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLeg([NotNull] PreposeGesturesParser.LegContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.leg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLeg([NotNull] PreposeGesturesParser.LegContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.angular_direction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAngular_direction([NotNull] PreposeGesturesParser.Angular_directionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.angular_direction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAngular_direction([NotNull] PreposeGesturesParser.Angular_directionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.dont"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDont([NotNull] PreposeGesturesParser.DontContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.dont"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDont([NotNull] PreposeGesturesParser.DontContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.ankles"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnkles([NotNull] PreposeGesturesParser.AnklesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.ankles"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnkles([NotNull] PreposeGesturesParser.AnklesContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.reference_plane"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReference_plane([NotNull] PreposeGesturesParser.Reference_planeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.reference_plane"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReference_plane([NotNull] PreposeGesturesParser.Reference_planeContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.sided_joint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSided_joint([NotNull] PreposeGesturesParser.Sided_jointContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.sided_joint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSided_joint([NotNull] PreposeGesturesParser.Sided_jointContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.legs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLegs([NotNull] PreposeGesturesParser.LegsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.legs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLegs([NotNull] PreposeGesturesParser.LegsContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PreposeGesturesParser.touch_restriction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTouch_restriction([NotNull] PreposeGesturesParser.Touch_restrictionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreposeGesturesParser.touch_restriction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTouch_restriction([NotNull] PreposeGesturesParser.Touch_restrictionContext context);
}
} // namespace PreposeGestures