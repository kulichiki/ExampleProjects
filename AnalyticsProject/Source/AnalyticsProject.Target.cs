using UnrealBuildTool;
using System.Collections.Generic;

public class AnalyticsProjectTarget : TargetRules
{
	public AnalyticsProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "AnalyticsProject" } );
	}
}
