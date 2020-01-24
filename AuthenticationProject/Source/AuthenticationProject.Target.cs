using UnrealBuildTool;
using System.Collections.Generic;

public class AuthenticationProjectTarget : TargetRules
{
	public AuthenticationProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "AuthenticationProject" } );
	}
}
