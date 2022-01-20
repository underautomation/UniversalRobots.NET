class SafetyStatus(int):
	Normal = 1
	Reduced = 2
	ProtectiveStop = 3
	Recovery = 4
	SafeguardStop = 5
	SystemEmergencyStop = 6
	RobotEmergencyStop = 7
	Violation = 8
	Fault = 9
	AutomaticModeSafeguardStop = 10
	SystemThreePositionEnablingStop = 11
