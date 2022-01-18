from enum import Enum

class RTDEStates(Enum):
	Disabled = 0
	Connecting = 1
	Started = 2
	Paused = 3
