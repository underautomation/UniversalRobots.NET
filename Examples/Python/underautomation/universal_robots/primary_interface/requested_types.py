from enum import Enum

class RequestedTypes(Enum):
	Boolean = 0
	Integer = 1
	Float = 2
	String = 3
	Pose = 4
	JointVector = 5
	Waypoint = 6
	Expression = 7
	None_ = 8
