from enum import Enum

class AuthenticationResult(Enum):
	Success = 0
	PartialSuccess = 1
	Failure = 2
