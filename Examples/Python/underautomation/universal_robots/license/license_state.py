from enum import Enum

class LicenseState(Enum):
	Invalid = 0
	Trial = 1
	ExtraTrial = 2
	Expired = 3
	MaintenanceNeeded = 4
	Licensed = 5
