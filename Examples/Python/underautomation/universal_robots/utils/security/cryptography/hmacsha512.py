import typing
from underautomation.universal_robots.utils.security.cryptography.hmac import HMAC
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Utils.Security.Cryptography import HMACSHA512 as hmacsha512

class HMACSHA512(HMAC):
	def __init__(self, key: int, hashSize: int, _internal = 0):
		if(_internal == 0):
			self._instance = hmacsha512(key, hashSize)
		else:
			self._instance = _internal
