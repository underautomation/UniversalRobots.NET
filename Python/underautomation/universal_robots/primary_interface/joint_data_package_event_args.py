import typing
from underautomation.universal_robots.primary_interface.joint_data import JointData
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import JointDataPackageEventArgs as joint_data_package_event_args

class JointDataPackageEventArgs(PackageEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = joint_data_package_event_args()
		else:
			self._instance = _internal
	@property
	def base(self) -> JointData:
		return JointData(self._instance.Base)
	@base.setter
	def base(self, value: JointData):
		self._instance.Base = value
	@property
	def shoulder(self) -> JointData:
		return JointData(self._instance.Shoulder)
	@shoulder.setter
	def shoulder(self, value: JointData):
		self._instance.Shoulder = value
	@property
	def elbow(self) -> JointData:
		return JointData(self._instance.Elbow)
	@elbow.setter
	def elbow(self, value: JointData):
		self._instance.Elbow = value
	@property
	def wrist1(self) -> JointData:
		return JointData(self._instance.Wrist1)
	@wrist1.setter
	def wrist1(self, value: JointData):
		self._instance.Wrist1 = value
	@property
	def wrist2(self) -> JointData:
		return JointData(self._instance.Wrist2)
	@wrist2.setter
	def wrist2(self, value: JointData):
		self._instance.Wrist2 = value
	@property
	def wrist3(self) -> JointData:
		return JointData(self._instance.Wrist3)
	@wrist3.setter
	def wrist3(self, value: JointData):
		self._instance.Wrist3 = value
