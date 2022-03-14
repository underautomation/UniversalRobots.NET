import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools import ExpectAction as expect_action

class ExpectAction:
	def __init__(self, expect: typing.Any, action: typing.Any, _internal = 0):
		if(_internal == 0):
			self._instance = expect_action(expect, action)
		else:
			self._instance = _internal
	@property
	def expect(self) -> typing.Any:
		return self._instance.Expect
	@property
	def action(self) -> typing.Any:
		return self._instance.Action
