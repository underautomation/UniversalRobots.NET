import typing
from underautomation.universal_robots.ssh.tools.common.big_integer import BigInteger
from underautomation.universal_robots.ssh.tools.messages.message import Message
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Messages.Transport import KeyExchangeDhGroupExchangeGroup as key_exchange_dh_group_exchange_group

class KeyExchangeDhGroupExchangeGroup(Message):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = key_exchange_dh_group_exchange_group()
		else:
			self._instance = _internal
	@property
	def safe_prime(self) -> BigInteger:
		return BigInteger(None, self._instance.SafePrime)
	@property
	def sub_group(self) -> BigInteger:
		return BigInteger(None, self._instance.SubGroup)
