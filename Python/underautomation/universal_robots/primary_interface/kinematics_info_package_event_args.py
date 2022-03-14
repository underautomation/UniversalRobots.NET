import typing
from underautomation.universal_robots.primary_interface.joint_kinematics_info import JointKinematicsInfo
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import KinematicsInfoPackageEventArgs as kinematics_info_package_event_args

class KinematicsInfoPackageEventArgs(PackageEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = kinematics_info_package_event_args()
		else:
			self._instance = _internal
	@property
	def calibration_status(self) -> int:
		return self._instance.CalibrationStatus
	@calibration_status.setter
	def calibration_status(self, value: int):
		self._instance.CalibrationStatus = value
	@property
	def base(self) -> JointKinematicsInfo:
		return JointKinematicsInfo(self._instance.Base)
	@base.setter
	def base(self, value: JointKinematicsInfo):
		self._instance.Base = value
	@property
	def shoulder(self) -> JointKinematicsInfo:
		return JointKinematicsInfo(self._instance.Shoulder)
	@shoulder.setter
	def shoulder(self, value: JointKinematicsInfo):
		self._instance.Shoulder = value
	@property
	def elbow(self) -> JointKinematicsInfo:
		return JointKinematicsInfo(self._instance.Elbow)
	@elbow.setter
	def elbow(self, value: JointKinematicsInfo):
		self._instance.Elbow = value
	@property
	def wrist1(self) -> JointKinematicsInfo:
		return JointKinematicsInfo(self._instance.Wrist1)
	@wrist1.setter
	def wrist1(self, value: JointKinematicsInfo):
		self._instance.Wrist1 = value
	@property
	def wrist2(self) -> JointKinematicsInfo:
		return JointKinematicsInfo(self._instance.Wrist2)
	@wrist2.setter
	def wrist2(self, value: JointKinematicsInfo):
		self._instance.Wrist2 = value
	@property
	def wrist3(self) -> JointKinematicsInfo:
		return JointKinematicsInfo(self._instance.Wrist3)
	@wrist3.setter
	def wrist3(self, value: JointKinematicsInfo):
		self._instance.Wrist3 = value
