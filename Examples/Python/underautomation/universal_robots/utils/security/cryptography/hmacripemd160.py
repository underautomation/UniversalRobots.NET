import typing
from underautomation.universal_robots.utils.security.cryptography.hmac import HMAC
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Utils.Security.Cryptography import HMACRIPEMD160 as hmacripemd160

class HMACRIPEMD160(HMAC):
	def __init__(self, key: int, _internal = 0):
		if(_internal == 0):
			self._instance = hmacripemd160(key)
		else:
			self._instance = _internal
