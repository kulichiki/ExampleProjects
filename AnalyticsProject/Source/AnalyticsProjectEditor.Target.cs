using UnrealBuildTool;
using System.Collections.Generic;

public class AnalyticsProjectEditorTarget : TargetRules
{
	public AnalyticsProjectEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "AnalyticsProject" } );
	}
}
