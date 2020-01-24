using UnrealBuildTool;
using System.Collections.Generic;

public class AuthenticationProjectEditorTarget : TargetRules
{
	public AuthenticationProjectEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "AuthenticationProject" } );
	}
}
