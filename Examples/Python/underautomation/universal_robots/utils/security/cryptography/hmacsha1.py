import typing
from underautomation.universal_robots.utils.security.cryptography.hmac import HMAC
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Utils.Security.Cryptography import HMACSHA1 as hmacsha1

class HMACSHA1(HMAC):
	def __init__(self, key: typing.List[int], hashSize: int, _internal = 0):
		if(_internal == 0):
			self._instance = hmacsha1(key, hashSize)
		else:
			self._instance = _internal
