import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots import JointsValues as joints_values_1

class JointsValues1:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = joints_values_1()
		else:
			self._instance = _internal
	def __repr__(self):
		return self._instance.ToString()
	@property
	def base(self) -> typing.Any:
		return self._instance.Base
	@base.setter
	def base(self, value: typing.Any):
		self._instance.Base = value
	@property
	def shoulder(self) -> typing.Any:
		return self._instance.Shoulder
	@shoulder.setter
	def shoulder(self, value: typing.Any):
		self._instance.Shoulder = value
	@property
	def elbow(self) -> typing.Any:
		return self._instance.Elbow
	@elbow.setter
	def elbow(self, value: typing.Any):
		self._instance.Elbow = value
	@property
	def wrist1(self) -> typing.Any:
		return self._instance.Wrist1
	@wrist1.setter
	def wrist1(self, value: typing.Any):
		self._instance.Wrist1 = value
	@property
	def wrist2(self) -> typing.Any:
		return self._instance.Wrist2
	@wrist2.setter
	def wrist2(self, value: typing.Any):
		self._instance.Wrist2 = value
	@property
	def wrist3(self) -> typing.Any:
		return self._instance.Wrist3
	@wrist3.setter
	def wrist3(self, value: typing.Any):
		self._instance.Wrist3 = value
